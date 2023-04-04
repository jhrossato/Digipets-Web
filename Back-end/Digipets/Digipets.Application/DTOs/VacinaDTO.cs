using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class VacinaDTO
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Tipo é um atributo obrigatório.")]
        public string Tipo { get; set; }
        [MinLength(2)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Nome é um atributo obrigatório.")]
        public string Nome { get; set; }
    }
}
