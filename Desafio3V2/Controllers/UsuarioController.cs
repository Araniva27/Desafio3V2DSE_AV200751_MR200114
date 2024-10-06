using Desafio3V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace Desafio3V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private UserManager<AppUser> userManager;
        private IPasswordHasher<AppUser> passwordHasher;
        private RoleManager<IdentityRole> roleManager;

        public UsuarioController(UserManager<AppUser> usrMgr, IPasswordHasher<AppUser> passwordHasher, RoleManager<IdentityRole> rolMgr)
        {
            userManager = usrMgr;
            this.passwordHasher = passwordHasher;
            roleManager = rolMgr;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] UsuarioT user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    UserName = user.Name,
                    Email = user.Email
                };

                IdentityResult result = await userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {                    
                    return CreatedAtAction(nameof(Login), new { email = appUser.Email }, new { message = "User created successfully" });
                }
                else
                {                    
                    return BadRequest(result.Errors);
                }
            }
            
            return BadRequest(ModelState);
        }

    }
}
