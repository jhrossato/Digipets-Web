using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IVeterinarioService
    {
        Task<IEnumerable<VeterinarioDTO>> GetVeterinarios();
        Task<VeterinarioDTO> GetById(int id);
        Task<VeterinarioDTO> Create(VeterinarioDTO veterinario);
        Task<VeterinarioDTO> Update(VeterinarioDTO veterinario);
        Task Delete(VeterinarioDTO veterinario);
    }
}
