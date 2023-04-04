using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Digipets.Infra.Data.EntitiesConfiguration
{
    internal class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Nome).HasMaxLength(64).IsRequired();
            builder.Property(a => a.Especie).HasMaxLength(32).IsRequired();
            builder.Property(a => a.Genero).HasMaxLength(16).IsRequired();
            builder.Property(a => a.Porte).HasMaxLength(16).IsRequired();
            builder.Property(a => a.Raca).HasMaxLength(32);
            builder.Property(a => a.Pelagem).HasMaxLength(16);
            builder.Property(a => a.Observacao).HasMaxLength(128);

            builder.HasOne(a => a.Tutor).WithMany(t => t.Animais).HasForeignKey(a => a.TutorId);
            builder.HasMany(a => a.Vacinas);
        }
    }
}
