//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace Digipets.API.Entities
//{
//    public sealed class Vacina
//    {
//        [Key]
//        [Column("Id")]
//        public int? Id { get; set; }
//        [Column("Tipo")]
//        [StringLength(25)]
//        public string Tipo { get; private set; }
//        [Column("Nome")]
//        [StringLength(25)]
//        public string Nome { get; private set; }
//        [Column("Dose")]
//        public int? Dose { get; private set; }
//        [Column("Data_Aplicacao")]
//        public DateTime DataAplicacao { get; private set; }

//        [Column("Id_Animal")]
//        public int AnimalId { get; private set; }
//        public Animal Animal { get; private set; }
//    }
//}
