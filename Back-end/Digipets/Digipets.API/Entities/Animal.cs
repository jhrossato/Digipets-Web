//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace Digipets.API.Entities
//{
//    public sealed class Animal
//    {
//        [Key]
//        [Column("Id")]
//        public int? Id { get; set; }
//        [Required]
//        [Column("Nome")]
//        [StringLength(50, ErrorMessage = "Nome é um requisito obrigatório.")]
//        public string Nome { get; private set; }
//        [Required]
//        [Column("Especie")]
//        [StringLength(12, ErrorMessage = "Especie é um requisito obrigatório.")]
//        public string Especie { get; private set; }
//        [Required]
//        [Column("Genero")]
//        [StringLength(12, ErrorMessage = "Genero é um requisito obrigatório.")]
//        public string Genero { get; private set; }
//        [Required]
//        [Column("Porte")]
//        [StringLength(12, ErrorMessage = "Porte é um requisito obrigatório.")]
//        public string Porte { get; private set; }
//        [Column("Raca")]
//        [StringLength(20)]
//        public string? Raca { get; private set; }
//        [Column("Nascimento")]
//        public DateTime? Nascimento { get; private set; }
//        [Column("Pelagem")]
//        public string? Pelagem { get; private set; }
//        [Column("Castrado")]
//        public bool? Castrado { get; private set; }
//        [Column("Observacao")]
//        public string? Observacao { get; private set; }

//        [Column("Id_Tutor")]
//        public int TutorId { get; private set; }
//        public Tutor Tutor { get; private set; }

//        public ICollection<Vacina> Vacinas { get; private set; }

//    }
//}
