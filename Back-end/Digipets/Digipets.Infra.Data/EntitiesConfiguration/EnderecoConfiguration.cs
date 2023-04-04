using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    internal class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Rua).HasMaxLength(32).IsRequired();
            builder.Property(e => e.Numero).IsRequired();
            builder.Property(e => e.Bairro).HasMaxLength(32).IsRequired();
            builder.Property(e => e.Cidade).HasMaxLength(32).IsRequired();
            builder.Property(e => e.Estado).HasMaxLength(32).IsRequired();
            builder.Property(e => e.CEP).HasMaxLength(16).IsRequired();
        }
    }
}
