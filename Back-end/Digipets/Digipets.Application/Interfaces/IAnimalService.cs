using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IAnimalService
    {
        Task<IEnumerable<AnimalDTO>> GetAnimaisByTutorId(int id);
        Task<AnimalDTO> GetById(int id);
        Task<AnimalDTO> Create(AnimalDTO animal);
        Task<AnimalDTO> Update(AnimalDTO animal);
        Task Delete(AnimalDTO animal);
    }
}
