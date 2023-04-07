using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVacinaService
    {
        Task<IEnumerable<VacinaDTO>> GetVacinas();
        Task<VacinaDTO> GetById(int id);
        Task<VacinaDTO> Create(VacinaDTO vacina);
        Task<VacinaDTO> Update(VacinaDTO vacina);
        Task Delete(VacinaDTO vacina);
    }
}
