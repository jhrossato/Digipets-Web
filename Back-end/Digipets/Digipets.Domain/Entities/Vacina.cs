using Digipets.Domain.Validation;

namespace Digipets.Domain.Entities
{
    public class Vacina
    {
        public int Id { get; set; }
        public string Tipo { get; private set; }
        public string Nome { get; private set; }

        public Vacina(int id, string tipo, string nome)
        {
            Id = id;
            Tipo = ValidateDomain(tipo, 3);
            Nome = ValidateDomain(nome, 3);
        }
        public Vacina(string tipo, string nome)
        {
            Tipo = ValidateDomain(tipo, 3);
            Nome = ValidateDomain(nome, 3);
        }
        public Vacina() { }
        private dynamic ValidateDomain(string field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }
    }
}
