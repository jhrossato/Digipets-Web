using Digipets.Domain.Validation;

namespace Digipets.Domain.Entities
{
    public sealed class Animal
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Especie { get; private set; }
        public string Genero { get; private set; }
        public string Porte { get; private set; }
        public string? Raca { get; private set; }
        public DateTime? Nascimento { get; private set; }
        public string? Pelagem { get; private set; }
        public bool Castrado { get; private set; }
        public string? Observacao { get; private set; }
        public int TutorId { get; set; }
        public Tutor Tutor { get; set; }
        public ICollection<VacinaAplicada>? Vacinas { get; set; }

        public Animal(int id, string nome, string especie,
            string genero, string porte, string? raca,
            DateTime? nascimento, string? pelagem, bool castrado,
            string? observacao, Tutor tutor, ICollection<VacinaAplicada>? vacinas)
        {
            Id = id;
            Nome = ValidateDomain(nome, 10);
            Especie = ValidateDomain(especie, 3);
            Genero = ValidateDomain(genero, 5);
            Porte = ValidateDomain(porte, 3);
            Raca = raca;
            Nascimento = nascimento;
            Pelagem = pelagem;
            Castrado = castrado;
            Observacao = observacao;
            Tutor = tutor;
            Vacinas = vacinas;
        }
        public Animal(string nome, string especie,
            string genero, string porte, string? raca,
            DateTime? nascimento, string? pelagem, bool castrado,
            string? observacao, Tutor tutor, ICollection<VacinaAplicada>? vacinas)
        {
            Nome = ValidateDomain(nome, 3);
            Especie = ValidateDomain(especie, 3);
            Genero = ValidateDomain(genero, 3);
            Porte = ValidateDomain(porte, 3);
            Raca = raca;
            Nascimento = nascimento;
            Pelagem = pelagem;
            Castrado = castrado;
            Observacao = observacao;
            Tutor = tutor;
            Vacinas = vacinas;
        }
        public Animal() { }
        private dynamic ValidateDomain(string field, int stringLength)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(field), $"O atributo {field} é obrigatório.");

            DomainExceptionValidation.When(field.Length < stringLength, $"O atributo {field} deve conter um tamanho mínimo de {stringLength} caracteres.");

            return field;
        }
    }
}
