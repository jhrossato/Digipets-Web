using System.ComponentModel.DataAnnotations;

namespace Digipets.Domain.Entities
{
    public class VacinaAplicada
    {
        public int Id { get; set; }
        [Range(1, 9)]
        public int Dose { get; private set; }
        public DateTime DataAplicacao { get; private set; }
        public int VacinaId { get; set; }
        public Vacina Vacina { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public VacinaAplicada(int id, int dose, DateTime dataAplicacao, Vacina vacina, Animal animal)
        {
            Id = id;
            Dose = dose;
            DataAplicacao = dataAplicacao;
            Vacina = vacina;
            Animal = animal;
        }
        public VacinaAplicada(int dose, DateTime dataAplicacao, Vacina vacina, Animal animal)
        {
            Dose = dose;
            DataAplicacao = dataAplicacao;
            Vacina = vacina;
            Animal = animal;
        }
        public VacinaAplicada() { }

    }
}
