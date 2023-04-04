using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    public class VeterinarioConfiguration : IEntityTypeConfiguration<Veterinario>
    {
        public void Configure(EntityTypeBuilder<Veterinario> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Nome).HasMaxLength(64).IsRequired();
            builder.Property(v => v.Email).HasMaxLength(64).IsRequired();
            builder.Property(v => v.Senha).HasMaxLength(16).IsRequired();
            builder.Property(v => v.Telefone).HasMaxLength(16);
            builder.Property(v => v.CRMV).HasMaxLength(16);

            builder.HasOne(v => v.Endereco).WithOne().HasForeignKey<Veterinario>(v => v.EnderecoId);
        }
    }
}
