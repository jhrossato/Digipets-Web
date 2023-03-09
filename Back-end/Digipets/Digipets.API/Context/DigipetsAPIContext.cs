using Digipets.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Digipets.API.Context
{
    public class DigipetsAPIContext : DbContext
    {
        public DigipetsAPIContext(DbContextOptions<DigipetsAPIContext> options) : base(options) { }

        public DbSet<Admin> TB_Admins { get; set; }
        public DbSet<Animal> TB_Animais { get; set; }
        public DbSet<Clinica> TB_Clinicas { get; set; }
        public DbSet<Endereco> TB_Enderecos { get; set; }
        public DbSet<Tutor> TB_Tutores { get; set; }
        public DbSet<Vacina> TB_Vacinas { get; set; }
        public DbSet<Veterinario> TB_Veterinarios { get; set; }
    }
}
