using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Application.DTOs
{
    public class VacinaDetailsDTO
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
    }
}
