using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class EnderecoDTO
    {
        public int Id { get;  set; }
        [MinLength(16)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Rua é um atributo obrigatório.")]
        public string Rua { get; set; }
        [Range(1, 9999)]
        [Required(ErrorMessage = "Numero é um atributo obrigatório.")]
        public int Numero { get; set; }
        [MinLength(3)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Bairro é um atributo obrigatório.")]
        public string Bairro { get; set; }
        [MinLength(4)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Cidade é um atributo obrigatório.")]
        public string Cidade { get; set; }
        [MinLength(2)]
        [MaxLength(2)]
        [Required(ErrorMessage = "Estado é um atributo obrigatório.")]
        public string Estado { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        [Required(ErrorMessage = "CEP é um atributo obrigatório.")]
        public string CEP { get; set; }
    }
}
