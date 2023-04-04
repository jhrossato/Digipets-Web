using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    internal class TutorConfiguration : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nome).HasMaxLength(64).IsRequired();
            builder.Property(t => t.Email).HasMaxLength(64).IsRequired();
            builder.Property(t => t.Senha).HasMaxLength(16).IsRequired();
            builder.Property(t => t.Telefone).HasMaxLength(16);
            builder.Property(t => t.CPF).HasMaxLength(16).IsRequired();
            builder.Property(t => t.RG).HasMaxLength(16);

            builder.HasOne(t => t.Endereco).WithOne().HasForeignKey<Tutor>(t => t.EnderecoId);
            builder.HasOne(t => t.Veterinario).WithMany(v => v.Tutores).HasForeignKey(t => t.VeterinarioId).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(t => t.Animais).WithOne(a => a.Tutor).HasForeignKey(x => x.TutorId);
        }
    }
}
