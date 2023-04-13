using System.ComponentModel.DataAnnotations;

namespace Digipets.Application.DTOs
{
    public class VacinaAplicadaDTO
    {
        [Range(1, 9)]
        public int Dose { get; set; }
        public DateTime DataAplicacao { get; set; }
        public int AnimalId { get; set; }
        public int VacinaId { get; set; }
    }
}
