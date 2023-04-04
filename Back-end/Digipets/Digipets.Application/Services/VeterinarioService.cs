using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;

namespace Digipets.Application.Services
{
    public class VeterinarioService : IVeterinarioService
    {
        private IVeterinarioRepository _repository;
        private readonly IMapper _mapper;
        public VeterinarioService(IVeterinarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(VeterinarioDTO veterinario)
        {
            var veterinarioEntity = _mapper.Map<Veterinario>(veterinario);
            await _repository.Create(veterinarioEntity);
        }

        public async Task Delete(VeterinarioDTO veterinario)
        {
            var veterinarioEntity = _mapper.Map<Veterinario>(veterinario);
            await _repository.Delete(veterinarioEntity);
        }

        public async Task<VeterinarioDTO> GetById(int id)
        {
            var veterinarioEntity = await _repository.GetById(id);
            return _mapper.Map<VeterinarioDTO>(veterinarioEntity);
        }

        public async Task<IEnumerable<VeterinarioDTO>> GetVeterinarios()
        {
            var veterinarioEntity = await _repository.GetVeterinarios();
            return _mapper.Map<IEnumerable<VeterinarioDTO>>(veterinarioEntity);
        }

        public async Task Update(VeterinarioDTO veterinario)
        {
            var veterinarioEntity = _mapper.Map<Veterinario>(veterinario);
            await _repository.Update(veterinarioEntity);
        }
    }
}
