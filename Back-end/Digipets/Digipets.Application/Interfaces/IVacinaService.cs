using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVacinaService
    {
        Task<IEnumerable<VacinaDetailsDTO>> GetVacinas();
        Task<VacinaDetailsDTO> GetById(int id);
        Task<VacinaDetailsDTO> Create(VacinaDTO vacina);
        Task<VacinaDetailsDTO> Update(VacinaDTO vacina);
        Task Delete(VacinaDetailsDTO vacina);
    }
}
