using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {
        private readonly ApplicationDbContext _context;
        public VeterinarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Veterinario> Create(Veterinario veterinario)
        {
            try
            {
                _context.Add(veterinario);
                await _context.SaveChangesAsync();
                return veterinario;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Veterinario veterinario)
        {
            try
            {
                _context.Remove(veterinario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<Veterinario> GetById(int id)
        {
            return await _context.veterinarios.Include(v => v.Endereco).AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Veterinario>> GetVeterinarios()
        {
            return await _context.veterinarios.Include(v => v.Endereco).AsNoTracking().ToListAsync();
        }

        public async Task<Veterinario> Update(Veterinario veterinario)
        {
            try
            {
                _context.Update(veterinario);
                await _context.SaveChangesAsync();
                return veterinario;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
