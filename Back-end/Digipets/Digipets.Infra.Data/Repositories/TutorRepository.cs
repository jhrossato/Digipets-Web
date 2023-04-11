using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class TutorRepository : ITutorRepository
    {
        ApplicationDbContext _context;
        public TutorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tutor> Create(Tutor tutor)
        {
            try
            {
                _context.Add(tutor);
                await _context.SaveChangesAsync();
                return tutor;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Tutor tutor)
        {
            try
            {
                _context.Remove(tutor);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<Tutor> GetById(int id)
        {
            return await _context.tutores.Include(v => v.Endereco).FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Tutor>> GetTutores()
        {
            return await _context.tutores.Include(v => v.Endereco).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Tutor>> GetTutoresByVeterinarioId(int id)
        {
            IQueryable<Tutor> tutores = _context.tutores;
            return await tutores.Include(t => t.Endereco).AsNoTracking().Where(t => t.VeterinarioId == id).ToListAsync();
        }

        public async Task<Tutor> Update(Tutor tutor)
        {
            try
            {
                _context.Update(tutor);
                await _context.SaveChangesAsync();
                return tutor;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
