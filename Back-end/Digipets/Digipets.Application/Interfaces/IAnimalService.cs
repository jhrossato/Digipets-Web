using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IAnimalService
    {
        Task<IEnumerable<AnimalDTO>> GetAnimaisByTutorId(int id);
        Task<AnimalDTO> GetById(int id);
        Task Create(AnimalDTO animal);
        Task Update(AnimalDTO animal);
        Task Delete(AnimalDTO animal);
    }
}
