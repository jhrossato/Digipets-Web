using Digipets.Domain.Entities;

namespace Digipets.Domain.Interfaces
{
    public interface IEnderecoRepository
    {
        Task<IEnumerable<Endereco>> GetEnderecos();
        Task<Endereco> GetById(int id);
        Task<Endereco> Create(Endereco endereco);
        Task<Endereco> Update(Endereco endereco);
        Task<bool> Delete(int id);
    }
}
