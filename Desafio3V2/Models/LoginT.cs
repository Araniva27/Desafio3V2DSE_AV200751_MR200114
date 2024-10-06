using System.ComponentModel.DataAnnotations;

namespace Desafio3V2.Models
{
    public class LoginT
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
