
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        ApplicationDbContext _context;
        public AnimalRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Animal> Create(Animal animal)
        {
            try
            {
                _context.Add(animal);
                await _context.SaveChangesAsync();
                return animal;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Animal animal)
        {
            try
            {
                _context.Remove(animal);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<Animal>> GetAnimaisByTutorId(int id)
        {
            IQueryable<Animal> animais = _context.animais;
            return await animais.AsNoTracking().Where(a => a.TutorId == id).ToListAsync();
        }

        public async Task<Animal> GetById(int id)
        {
            return await _context.animais.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Animal> Update(Animal animal)
        {
            try
            {
                _context.Update(animal);
                await _context.SaveChangesAsync();
                return animal;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
