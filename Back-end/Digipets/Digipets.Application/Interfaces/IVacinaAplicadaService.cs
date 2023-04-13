using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVacinaAplicadaService
    {
        Task<IEnumerable<VacinaAplicadaDetailsDTO>> GetVacinasByAnimalId(int id);
        Task<VacinaAplicadaDetailsDTO> GetById(int id);
        Task<VacinaAplicadaDetailsDTO> Create(VacinaAplicadaDTO vacina);
        Task<VacinaAplicadaDetailsDTO> Update(VacinaAplicadaDTO vacina);
        Task Delete(VacinaAplicadaDetailsDTO vacina);
    }
}
