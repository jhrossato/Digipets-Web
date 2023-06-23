using Bogus;
using Digipets.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Test.FakeEntity
{
    internal class AnimalDTOFaker : Faker<AnimalDTO>
    {
        public AnimalDTOFaker()
        {
            var id = new Faker().Random.Number(1, 999);
            RuleFor(p => p.Id, f => id);
            RuleFor(p => p.Nome, f => f.Person.FullName);
            RuleFor(p => p.Especie, f => f.Random.Word());
            RuleFor(p => p.Genero, f => f.Random.Word());
            RuleFor(p => p.Porte, f => f.Random.Word());
            RuleFor(p => p.Raca, f => f.Random.Word());
            RuleFor(p => p.Pelagem, f => f.Random.Word());
            RuleFor(p => p.Castrado, f => f.Random.Bool());
            RuleFor(p => p.Observacao, f => f.Random.Word());
            RuleFor(p => p.TutorId, f => f.Random.Number(1, 999));
        }
    }
}
