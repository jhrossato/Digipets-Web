using Digipets.Domain.Entities;

namespace Digipets.Domain.Interfaces
{
    public interface ITutorRepository
    {
        Task<IEnumerable<Tutor>> GetTutores();
        Task<IEnumerable<Tutor>> GetTutoresByVeterinarioId(int id);
        Task<Tutor> GetById(int id);
        Task<Tutor> Create(Tutor tutor);
        Task<Tutor> Update(Tutor tutor);
        Task<bool> Delete(Tutor tutor);
    }
}
