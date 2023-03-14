using Digipets.API.Entities;
using System.ComponentModel.DataAnnotations;

namespace Digipets.API.ViewModels
{
    public class CreateClinicaViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string CRMV { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string MAPA { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public CreateEnderecoViewModel Endereco { get; set; }
        [Required]
        public CreateAdminViewModel Admin { get; set; }
    }
}
