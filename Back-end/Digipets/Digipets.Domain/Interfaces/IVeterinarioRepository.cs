using Digipets.Domain.Entities;


namespace Digipets.Domain.Interfaces
{
    public interface IVeterinarioRepository
    {
        Task<IEnumerable<Veterinario>> GetVeterinarios();
        Task<Veterinario> GetById(int id);
        Task<Veterinario> Create(Veterinario veterinario);
        Task<Veterinario> Update(Veterinario veterinario);
        Task<bool> Delete(Veterinario veterinario);
    }
}
