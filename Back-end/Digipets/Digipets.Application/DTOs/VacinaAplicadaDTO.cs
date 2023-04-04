using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class VacinaAplicadaDTO
    {
        public int Id { get; set; }
        [Range(1, 9)]
        public int Dose { get; set; }
        public DateTime DataAplicacao { get; set; }
        public int AnimalId { get; set; }
        public VacinaDTO Vacina { get; set; }
    }
}
