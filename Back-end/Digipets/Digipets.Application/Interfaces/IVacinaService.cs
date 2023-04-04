using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVacinaService
    {
        Task<IEnumerable<VacinaDTO>> GetVacinas();
        Task<VacinaDTO> GetById(int id);
        Task Create(VacinaDTO vacina);
        Task Update(VacinaDTO vacina);
        Task Delete(VacinaDTO vacina);
    }
}
