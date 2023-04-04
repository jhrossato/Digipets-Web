using Digipets.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Veterinario> veterinarios { get; set; }
        public DbSet<Tutor> tutores { get; set; }
        public DbSet<Endereco> enderecos { get; set; }
        public DbSet<Animal> animais { get; set; }
        public DbSet<Vacina> vacinas { get; set; }
        public DbSet<VacinaAplicada> vacinaAplicadas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
