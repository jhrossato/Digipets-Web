using Digipets.Domain.Entities;

namespace Digipets.Domain.Interfaces
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAnimaisByTutorId(int id);
        Task<Animal> GetById(int id);
        Task<Animal> Create(Animal animal);
        Task<Animal> Update(Animal animal);
        Task<bool> Delete(Animal animal);
    }
}
