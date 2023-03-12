using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Digipets.API.Entities
{
    public sealed class Endereco
    {
        [Key]
        [Column("Id")]
        public int? Id { get; set; }
        [Required]
        [Column("Rua")]
        [StringLength(50, ErrorMessage = "A rua é um requisito obrigatório.")]
        public string Rua { get; private set; }
        [Required]
        [Column("Numero")]
        [Range(1, 9999, ErrorMessage = "O número é requisito obrigatório.")]
        public int Numero { get; private set; }
        [Required]
        [Column("Bairro")]
        [StringLength(28, ErrorMessage = "O bairro é um requisito obrigatório.")]
        public string Bairro { get; private set; }
        [Required]
        [Column("Cidade")]
        [StringLength(28, ErrorMessage = "A Cidade é um requisito obrigatório.")]
        public string Cidade { get; private set; }
        [Required]
        [Column("CEP")]
        [StringLength(9, ErrorMessage = "O CEP é um requisito obrigatório.")]
        public int CEP { get; private set; }

        public Clinica Clinica { get; private set; }
        public int ClinicaId { get; private set; }

        public Veterinario Veterinario { get; private set; }
        public int VeterinarioId { get; private set; }

    }
}
