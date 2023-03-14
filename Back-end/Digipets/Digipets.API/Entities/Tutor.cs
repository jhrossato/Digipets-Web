//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace Digipets.API.Entities
//{
//    public sealed class Tutor : UserBase
//    {
//        [Column("CPF")]
//        [StringLength(14)]
//        public string? CPF { get; private set; }
//        [Column("RG")]
//        [StringLength(25)]
//        public string? RG { get; private set; }        
//        [Column("Telefone")]
//        [StringLength(18)]
//        public string? Telefone { get; private set; }

//        [Column("Id_Endereco")]
//        public int? EnderecoId { get; private set; }
//        public Endereco? Endereco { get; private set; }

//        [Column("Id_Veterinario")]
//        public int VeterinarioId { get; private set; }
//        public Veterinario Veterinario { get; private set; }

//        public ICollection<Animal> Animais { get; private set; }
//    }
//}
