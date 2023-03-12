using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace Digipets.API.Entities
{
    public sealed class Clinica
    {
        public int? Id { get; set; }
        public string Nome { get; private set; }
        public string CRMV { get; private set; }
        public string CNPJ { get; private set; }
        public string MAPA { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public Admin Admin { get; private set; }
        public ICollection<Veterinario> Veterinarios { get; private set; }

        public Clinica()
        {
            Veterinarios = new Collection<Veterinario>();
        }
    }
}
