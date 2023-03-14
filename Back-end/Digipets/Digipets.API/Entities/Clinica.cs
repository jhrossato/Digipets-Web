using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace Digipets.API.Entities
{
    [Table("TB_Clinicas")]
    public sealed class Clinica
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string CNPJ { get; set; }
        public string MAPA { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public Admin Admin { get; set; }
        //public ICollection<Veterinario> Veterinarios { get; private set; }

        public Clinica()
        {
            //Veterinarios = new Collection<Veterinario>();
        }
    }
}
