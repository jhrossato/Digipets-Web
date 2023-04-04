using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        ApplicationDbContext _context;
        public EnderecoRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Endereco> Create(Endereco endereco)
        {
            try
            {
                _context.Add(endereco);
                await _context.SaveChangesAsync();
                return endereco;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                _context.Remove(id);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<Endereco> GetById(int id)
        {
            return await _context.enderecos.FindAsync(id);
        }

        public async Task<IEnumerable<Endereco>> GetEnderecos()
        {
            return await _context.enderecos.ToListAsync();
        }

        public async Task<Endereco> Update(Endereco endereco)
        {
            try
            {
                _context.Update(endereco);
                await _context.SaveChangesAsync();
                return endereco;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
