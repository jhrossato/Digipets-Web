using System.ComponentModel.DataAnnotations;

namespace Digipets.API.ViewModels
{
    public class CreateEnderecoViewModel
    {
        [Required]
        public string Rua { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public int CEP { get; set; }
    }
}
