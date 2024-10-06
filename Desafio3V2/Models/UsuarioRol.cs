using System.ComponentModel.DataAnnotations;

namespace Desafio3V2.Models
{
    public class UsuarioRol
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string RoleName { get; set; }
    }
}
