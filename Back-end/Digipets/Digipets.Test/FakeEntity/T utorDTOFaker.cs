using Bogus;
using Digipets.Application.DTOs;
using Bogus.Extensions.Brazil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Test.FakeEntity
{
    internal class TutorDTOFaker : Faker<TutorDTO>
    {
        public TutorDTOFaker()
        {
            var id = new Faker().Random.Number(1, 999);
            RuleFor(p => p.Id, f => id);
            RuleFor(p => p.Nome, f => f.Person.FullName);
            RuleFor(p => p.Email, f => f.Person.Email);
            RuleFor(p => p.Senha, f => f.Random.Number(100000, 110000).ToString());
            RuleFor(p => p.Telefone, f => f.Random.Number(2000000, 2100000).ToString());
            RuleFor(p => p.Endereco, f => new EnderecoDTOFaker().Generate());
            RuleFor(p => p.VeterinarioId, f => f.Random.Number(1, 999));
            RuleFor(p => p.CPF, f => f.Person.Cpf());
            RuleFor(p => p.RG, f => f.Random.Number(1000000, 1100000).ToString());

        }
    }
}
