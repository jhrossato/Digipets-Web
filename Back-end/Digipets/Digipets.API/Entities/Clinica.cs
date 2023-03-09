using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace Digipets.API.Entities
{
    public sealed class Clinica
    {
        [Key]
        [Column("Id")]
        public int? Id { get; set; }
        [Required]
        [Column("Nome")]
        [StringLength(50, ErrorMessage = "Nome é um requisito obrigatório.")]
        public string Nome { get; private set; }
        [Required]
        [Column("CRMV")]
        [StringLength(10, ErrorMessage = "CRMV é um requisito obrigatório.")]
        public string CRMV { get; private set; }
        [Required]
        [Column("CNPJ")]
        [StringLength(18, ErrorMessage = "CNPJ é um requisito obrigatório.")]
        public string CNPJ { get; private set; }
        [Required]
        [Column("MAPA")]
        [StringLength(10, ErrorMessage = "MAPA é um requisito obrigatório.")]
        public string MAPA { get; private set; }
        [Required]
        [Column("Telefone")]
        [StringLength(18, ErrorMessage = "Telefone é um requisito obrigatório.")]
        public string Telefone { get; private set; }
        [Required]
        [Column("Email")]
        [StringLength(10, ErrorMessage = "Email é um requisito obrigatório.")]
        public string Email { get; private set; }

        [Column("Id_Endereco")]
        public int Id_Endereco { get; private set; }
        public Endereco Endereco { get; private set; }

        [Column("Id_Admin")]
        public int AdminId { get; private set; }
        public Admin Admin { get; private set; }

        public ICollection<Veterinario> Veterinarios { get; private set; }

        public Clinica()
        {
            Veterinarios = new Collection<Veterinario>();
        }
    }
}
