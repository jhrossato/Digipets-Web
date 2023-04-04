using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class AnimalDTO
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(64)]
        [Required(ErrorMessage = "Nome é um atributo obrigatório.")]
        public string Nome { get; set; }
        [MinLength(4)]
        [MaxLength(32)]
        [Required(ErrorMessage = "Especie é um atributo obrigatório.")]
        public string Especie { get; set; }
        [MinLength(4)]
        [MaxLength(16)]
        [Required(ErrorMessage = "Genero é um atributo obrigatório.")]
        public string Genero { get; set; }
        [MinLength(4)]
        [MaxLength(16)]
        [Required(ErrorMessage = "Porte é um atributo obrigatório.")]
        public string Porte { get; set; }
        [MinLength(4)]
        [MaxLength(32)]
        public string? Raca { get; set; }
        public DateTime? Nascimento { get; set; }
        [MinLength(4)]
        [MaxLength(16)]
        public string? Pelagem { get; set; }
        public bool Castrado { get; set; }
        [MinLength(2)]
        [MaxLength(128)]
        public string? Observacao { get; set; }
        public int TutorId { get; set; }
    }
}
