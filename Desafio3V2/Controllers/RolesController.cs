using Desafio3V2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Desafio3V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<AppUser> userManager;

        public RolesController(RoleManager<IdentityRole> roleMgr, UserManager<AppUser> userMrg)
        {
            roleManager = roleMgr;
            userManager = userMrg;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                {                    
                    return CreatedAtAction(nameof(Create), new { roleName = name }, new { message = "Role created successfully" });
                }
                else
                {                    
                    return BadRequest(result.Errors);
                }
            }
            
            return BadRequest(ModelState);
        }

        [HttpPost("assign")]
        public async Task<IActionResult> AssignRole([FromBody] UsuarioRol userRoleDto)
        {
            if (ModelState.IsValid)
            {
                // Buscar el usuario por email o nombre de usuario
                var user = await userManager.FindByEmailAsync(userRoleDto.Email);
                if (user == null)
                {
                    return NotFound(new { message = "User not found" });
                }

                // Verificar si el rol existe
                if (!await roleManager.RoleExistsAsync(userRoleDto.RoleName))
                {
                    return NotFound(new { message = "Role not found" });
                }

                // Asignar el rol al usuario
                var result = await userManager.AddToRoleAsync(user, userRoleDto.RoleName);
                if (result.Succeeded)
                {
                    return Ok(new { message = $"Role {userRoleDto.RoleName} assigned to user {userRoleDto.Email}" });
                }

                // Si hubo errores al asignar el rol, devolverlos
                return BadRequest(result.Errors);
            }

            return BadRequest(ModelState);
        }


    }
}
