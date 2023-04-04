using Digipets.Application.DTOs;

namespace Digipets.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task<IEnumerable<EnderecoDTO>> GetEnderecos();
        Task<EnderecoDTO> GetById(int id);
        Task Create(EnderecoDTO endereco);
        Task Update(EnderecoDTO endereco);
        Task Delete(int id);
    }
}
