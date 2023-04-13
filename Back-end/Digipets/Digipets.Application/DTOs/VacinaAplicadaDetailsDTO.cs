using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Application.DTOs
{
    public class VacinaAplicadaDetailsDTO
    {
        public int Id { get; set; }
        public int Dose { get; set; }
        public DateTime DataAplicacao { get; set; }
        public VacinaDetailsDTO Vacina { get; set; }
    }
}
