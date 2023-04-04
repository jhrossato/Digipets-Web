using Digipets.Domain.Validation;

namespace Digipets.Domain.Entities
{
    public sealed class Tutor : UserBase
    {
        public string CPF { get; private set; }
        public string? RG { get; private set; }
        public int VeterinarioId { get; set; }
        public Veterinario Veterinario { get; set; }
        public ICollection<Animal> Animais { get; set; }

        public Tutor(int id, string nome, string email,
            string senha, string telefone, Endereco endereco, string cpf, string rg,
            Veterinario veterinario, ICollection<Animal> animais) :
            base(id, nome, email, senha, telefone, endereco)
        {
            CPF = ValidateDomain(cpf, 11);
            RG = ValidateDomain(rg, 8);
            Veterinario = veterinario;
            Animais = animais;
        }

        public Tutor(string nome, string email,
            string senha, string telefone, Endereco endereco, string cpf, string rg, Veterinario veterinario, ICollection<Animal> animais) :
            base(nome, email, senha, telefone, endereco)
        {
            CPF = ValidateDomain(cpf, 11);
            RG = ValidateDomain(rg, 8);
            Veterinario = veterinario;
        }
        public Tutor() { }
        private dynamic ValidateDomain(dynamic field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }
    }
}
