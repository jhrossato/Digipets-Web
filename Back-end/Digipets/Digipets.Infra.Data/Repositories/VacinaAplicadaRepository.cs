using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class VacinaAplicadaRepository : IVacinaAplicadaRepository
    {
        ApplicationDbContext _context;
        public VacinaAplicadaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<VacinaAplicada> Create(VacinaAplicada vacina)
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

        public async Task<bool> Delete(VacinaAplicada vacina)
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

        public async Task<VacinaAplicada> GetById(int id)
        {
            return await _context.vacinaAplicadas.Include(v => v.Vacina).AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<VacinaAplicada>> GetVacinasByAnimalId(int id)
        {
            IQueryable<VacinaAplicada> vacinasAplicadas = _context.vacinaAplicadas;
            return await vacinasAplicadas.Include(v => v.Vacina).AsNoTracking().Where(v => v.AnimalId == id).ToListAsync();
        }

        public async Task<VacinaAplicada> Update(VacinaAplicada vacina)
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
