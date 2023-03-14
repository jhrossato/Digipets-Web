using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Digipets.API.Entities
{
    [Table("TB_Enderecos")]
    public sealed class Endereco
    {
        public int? Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int CEP { get; set; }

        //public Clinica Clinica { get; private set; }
        public int ClinicaId { get; set; }

        //public Veterinario Veterinario { get; private set; }
        //public int VeterinarioId { get; private set; }

    }
}
