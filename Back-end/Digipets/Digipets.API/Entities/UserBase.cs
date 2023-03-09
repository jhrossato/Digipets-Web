using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Digipets.API.Entities
{
    public abstract class UserBase
    {
        [Key]
        [Column("Id")]
        public int? Id { get; set; }
        [Required]
        [Column("Nome")]
        [StringLength(50, ErrorMessage = "Nome é um requisito obrigatório.")]
        public string Nome { get; private set; }
        [Required]
        [Column("Email")]
        [StringLength(50, ErrorMessage = "E-mail é um requisito obrigatório.")]
        public string Email { get; private set; }
        [Required]
        [Column("Senha")]
        [StringLength(18, ErrorMessage = "A senha é um requisito obrigatório.")]
        public string Senha { get; private set; }
    }
}
