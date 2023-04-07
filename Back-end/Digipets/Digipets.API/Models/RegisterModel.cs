using System.ComponentModel.DataAnnotations;

namespace Digipets.API.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "A confirmação deve ser igual a senha inserida")]
        public string ConfirmPassword { get; set; }
    }
}
