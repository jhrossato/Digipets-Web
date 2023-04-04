using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;

namespace Digipets.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private IEnderecoRepository _repository;
        private readonly IMapper _mapper;
        public EnderecoService(IEnderecoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(EnderecoDTO endereco)
        {
            var enderecoEntity = _mapper.Map<Endereco>(endereco);
            await _repository.Create(enderecoEntity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<EnderecoDTO> GetById(int id)
        {
            var enderecoEntity = await _repository.GetById(id);
            return _mapper.Map<EnderecoDTO>(enderecoEntity);
        }

        public async Task<IEnumerable<EnderecoDTO>> GetEnderecos()
        {
            var enderecosEntity = await _repository.GetEnderecos();
            return _mapper.Map<IEnumerable<EnderecoDTO>>(enderecosEntity);
        }

        public async Task Update(EnderecoDTO endereco)
        {
            var enderecoEntity = _mapper.Map<Endereco>(endereco);
            await _repository.Update(enderecoEntity);
        }
    }
}
