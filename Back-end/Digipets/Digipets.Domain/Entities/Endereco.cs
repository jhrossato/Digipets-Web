using Digipets.Domain.Validation;
using System.ComponentModel.DataAnnotations;

namespace Digipets.Domain.Entities
{
    public sealed class Endereco
    {
        public int Id { get; private set; }
        public string Rua { get; private set; }
        [Range(1, 9999)]
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }

        public Endereco(int id, string rua, int numero, string bairro, string cidade, string estado, string cep)
        {
            Id = id;
            Rua = ValidateDomain(rua, 3);
            Numero = numero;
            Bairro = ValidateDomain(bairro, 3);
            Cidade = ValidateDomain(cidade, 3);
            Estado = ValidateDomain(estado, 2);
            CEP = cep;
        }
        public Endereco(string rua, int numero, string bairro, string cidade, string estado, string cep)
        {
            Rua = ValidateDomain(rua, 3);
            Numero = numero;
            Bairro = ValidateDomain(bairro, 3);
            Cidade = ValidateDomain(cidade, 3);
            Estado = ValidateDomain(estado, 2);
            CEP = cep;
        }
        public Endereco() { }
        private dynamic ValidateDomain(string field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }
    }
}
