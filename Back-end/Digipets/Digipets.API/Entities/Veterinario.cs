using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Digipets.API.Entities
{
    public sealed class Veterinario : UserBase
    {
        [Required]
        [Column("CRMV")]
        [StringLength(10, ErrorMessage = "CRMV é um requisito obrigatório.")]
        public string CRMV { get; private set; }
        [Required]
        [Column("Telefone")]
        [StringLength(18, ErrorMessage = "Telefone é um requisito obrigatório.")]
        public string Telefone { get; private set; }

        [Column("Id_Clinica")]
        public int? ClinicaId { get; private set; }
        public Clinica? Clinica { get; private set; }

        public ICollection<Tutor> Tutores { get; private set; }

    }
}
