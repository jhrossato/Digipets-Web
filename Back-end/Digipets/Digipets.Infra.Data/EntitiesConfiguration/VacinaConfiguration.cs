using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    internal class VacinaConfiguration : IEntityTypeConfiguration<Vacina>
    {
        public void Configure(EntityTypeBuilder<Vacina> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Tipo).HasMaxLength(32).IsRequired();
            builder.Property(v => v.Nome).HasMaxLength(32).IsRequired();
        }
    }
}
