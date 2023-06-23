using Bogus;
using Digipets.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Test.FakeEntity
{
    internal class EnderecoDTOFaker : Faker<EnderecoDTO>
    {
        public EnderecoDTOFaker()
        {
            var id = new Faker().Random.Number(1, 999);
            RuleFor(p => p.Id, f => id);
            RuleFor(p => p.Rua, f => f.Address.StreetName());
            RuleFor(p => p.Numero, f => f.Random.Number(100000, 110000));
            RuleFor(p => p.Bairro, f => f.Random.Words());
            RuleFor(p => p.Cidade, f => f.Address.City());
            RuleFor(p => p.Estado, f => f.Address.StateAbbr());
            RuleFor(p => p.CEP, f => f.Address.ZipCode());
        }
    }
}
