using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class VacinaRepository : IVacinaRepository
    {
        ApplicationDbContext _context;
        public VacinaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Vacina> Create(Vacina vacina)
        {
            try
            {
                _context.Add(vacina);
                await _context.SaveChangesAsync();
                return vacina;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Vacina vacina)
        {
            try
            {
                _context.Remove(vacina);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<Vacina> GetById(int id)
        {
            return await _context.vacinas.AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Vacina>> GetVacinas()
        {
            return await _context.vacinas.AsNoTracking().ToListAsync();
        }

        public async Task<Vacina> Update(Vacina vacina)
        {
            try
            {
                _context.Update(vacina);
                await _context.SaveChangesAsync();
                return vacina;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
