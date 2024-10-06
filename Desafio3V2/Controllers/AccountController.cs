using Desafio3V2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace Desafio3V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private UserManager<AppUser> userManager;
        private SignInManager<AppUser> signInManager;
        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginT login)
        {
            if (ModelState.IsValid)
            {
                // Buscar al usuario por su correo electrónico
                AppUser appUser = await userManager.FindByEmailAsync(login.Email);
                if (appUser != null)
                {
                    // Cerrar cualquier sesión existente
                    await signInManager.SignOutAsync();

                    // Intentar iniciar sesión con el usuario y la contraseña
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(appUser, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        // En lugar de redirigir, devolvemos un 200 OK con un mensaje de éxito
                        return Ok(new { message = "Login successful" });
                    }
                }

                // Si el login falla, devolver un mensaje de error
                ModelState.AddModelError(nameof(login.Email), "Login failed: Invalid email or password");
                return BadRequest(ModelState);
            }

            // Si el modelo no es válido, devolver los errores de validación
            return BadRequest(ModelState);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            // Cerrar sesión
            await signInManager.SignOutAsync();

            // Devolver una respuesta exitosa
            return Ok(new { message = "Logout successful" });
        }


    }
}
