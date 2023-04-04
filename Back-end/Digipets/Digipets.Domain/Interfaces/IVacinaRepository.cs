using Digipets.Domain.Entities;

namespace Digipets.Domain.Interfaces
{
    public interface IVacinaRepository
    {
        Task<IEnumerable<Vacina>> GetVacinas();
        Task<Vacina> GetById(int id);
        Task<Vacina> Create(Vacina vacina);
        Task<Vacina> Update(Vacina vacina);
        Task<bool> Delete(Vacina vacina);
    }
}
