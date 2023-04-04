using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    internal class VacinaAplicadaConfiguration : IEntityTypeConfiguration<VacinaAplicada>
    {
        public void Configure(EntityTypeBuilder<VacinaAplicada> builder)
        {
            builder.HasKey(v => v.Id);
            builder.HasOne(v => v.Vacina);
            builder.HasOne(v => v.Animal);
        }
    }
}