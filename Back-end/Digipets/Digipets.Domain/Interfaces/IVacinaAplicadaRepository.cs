using Digipets.Domain.Entities;

namespace Digipets.Domain.Interfaces
{
    public interface IVacinaAplicadaRepository
    {
        Task<IEnumerable<VacinaAplicada>> GetVacinasByAnimalId(int id);
        Task<VacinaAplicada> GetById(int id);
        Task<VacinaAplicada> Create(VacinaAplicada vacina);
        Task<VacinaAplicada> Update(VacinaAplicada vacina);
        Task<bool> Delete(VacinaAplicada vacina);
    }
}
