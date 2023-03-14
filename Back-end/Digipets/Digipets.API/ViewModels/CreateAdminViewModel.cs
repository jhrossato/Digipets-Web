using System.ComponentModel.DataAnnotations;

namespace Digipets.API.ViewModels
{
    public class CreateAdminViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
