using Digipets.Domain.Validation;

namespace Digipets.Domain.Entities
{
    public sealed class Veterinario : UserBase
    {
        public string CRMV { get; private set; }
        public ICollection<Tutor> Tutores { get; private set; }

        public Veterinario(int id, string nome, string email,
                        string senha, string telefone, Endereco endereco, string crmv) :
                        base(id, nome, email, senha, telefone, endereco)
        {
            CRMV = ValidateDomain(crmv, 3);
        }

        public Veterinario(string nome, string email,
                        string senha, string telefone, Endereco endereco, string crmv) :
                        base(nome, email, senha, telefone, endereco)
        {
            CRMV = ValidateDomain(crmv, 3);
        }
        public Veterinario() { }
        private dynamic ValidateDomain(string field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }



    }
}
