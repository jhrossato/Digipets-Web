using Digipets.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digipets.API.Context
{
    public class DigipetsAPIContext : DbContext
    {
        public DigipetsAPIContext(DbContextOptions<DigipetsAPIContext> options) : base(options) { }

        //public DbSet<Admin> TB_Admins { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Clinica> TB_Clinicas { get; set; }
        //public DbSet<Endereco> TB_Enderecos { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Clinica>()
                .ToTable("TB_Clinicas")
                .Property(c => c.Nome).HasMaxLength(50)
                .HasColumnOrder(2);

            mb.Entity<Clinica>()
                .Property(c => c.CRMV).HasMaxLength(10)
                .HasColumnOrder(3);

            mb.Entity<Clinica>()
                .Property(c => c.CNPJ).HasMaxLength(18)
                .HasColumnOrder(4);

            mb.Entity<Clinica>()
                .Property(c => c.MAPA).HasMaxLength(10)
                .HasColumnOrder(5);

            mb.Entity<Clinica>()
                .Property(c => c.Telefone).HasMaxLength(18)
                .HasColumnOrder(6);

            mb.Entity<Clinica>()
                .Property(c => c.Email).HasMaxLength(50)
                .HasColumnOrder(7);

            mb.Entity<Clinica>()
                .HasOne(c => c.Endereco)
                .WithOne(e => e.Clinica);

            mb.Entity<Clinica>()
                .HasOne(c => c.Admin)
                .WithOne(a => a.Clinica);

            mb.Entity<Clinica>()
                .HasMany(c => c.Veterinarios)
                .WithOne(v => v.Clinica);

            //base.OnModelCreating(mb);
        }


    }
}
