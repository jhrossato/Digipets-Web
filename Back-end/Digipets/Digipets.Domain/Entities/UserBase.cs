using Digipets.Domain.Validation;

namespace Digipets.Domain.Entities
{
    public abstract class UserBase
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Telefone { get; private set; }
        public int EnderecoId { get; private set; }
        public Endereco Endereco { get; private set; }

        public UserBase(int id, string nome, string email, string senha, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = ValidateDomain(nome, 10);
            Email = ValidateDomain(email, 12);
            Senha = ValidateDomain(senha, 8);
            Telefone = ValidateDomain(telefone, 10);
            Endereco = endereco;

        }

        public UserBase(string nome, string email, string senha, string telefone, Endereco endereco)
        {
            Nome = ValidateDomain(nome, 10);
            Email = ValidateDomain(email, 12);
            Senha = ValidateDomain(senha, 8);
            Telefone = ValidateDomain(telefone, 10);
            Endereco = endereco;

        }
        public UserBase() { }
        private dynamic ValidateDomain(dynamic field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }
    }
}
