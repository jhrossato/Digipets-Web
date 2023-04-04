using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVacinaAplicadaService
    {
        Task<IEnumerable<VacinaAplicadaDTO>> GetVacinasByAnimalId(int id);
        Task<VacinaAplicadaDTO> GetById(int id);
        Task Create(VacinaAplicadaDTO vacina);
        Task Update(VacinaAplicadaDTO vacina);
        Task Delete(VacinaAplicadaDTO vacina);
    }
}
