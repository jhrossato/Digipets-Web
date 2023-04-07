using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface ITutorService
    {
        Task<IEnumerable<TutorDTO>> GetTutores();
        Task<IEnumerable<TutorDTO>> GetTutoresByVeterinarioId(int id);
        Task<TutorDTO> GetById(int id);
        Task<TutorDTO> Create(TutorDTO tutor);
        Task<TutorDTO> Update(TutorDTO tutor);
        Task Delete(TutorDTO tutor);
    }
}
