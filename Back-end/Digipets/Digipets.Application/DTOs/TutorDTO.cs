using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class TutorDTO
    {
        public int Id { get; set; }
        [MinLength(16)]
        [MaxLength(64)]
        [Required(ErrorMessage = "Nome é um atributo obrigatório.")]
        public string Nome { get; set; }
        [MinLength(16)]
        [MaxLength(64)]
        [Required(ErrorMessage = "E-mail é um atributo obrigatório.")]
        public string Email { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        [Required(ErrorMessage = "Senha é um atributo obrigatório.")]
        public string Senha { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        public string Telefone { get; set; }
        public EnderecoDTO Endereco { get; set; }
        [MinLength(11)]
        [MaxLength(16)]
        [Required(ErrorMessage = "CPF é um atributo obrigatório.")]
        public string CPF { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        public string? RG { get; set; }
        public int VeterinarioId { get; set; }
    }
}
