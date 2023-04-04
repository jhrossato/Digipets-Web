using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;

namespace Digipets.Application.Services
{
    public class VacinaService : IVacinaService
    {
        private IVacinaRepository _repository;
        private readonly IMapper _mapper;
        public VacinaService(IVacinaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(VacinaDTO vacina)
        {
            var vacinaEntity = _mapper.Map<Vacina>(vacina);
            await _repository.Create(vacinaEntity);
        }

        public async Task Delete(VacinaDTO vacina)
        {
            var vacinaEntity = _mapper.Map<Vacina>(vacina);
            await _repository.Delete(vacinaEntity);
        }

        public async Task<VacinaDTO> GetById(int id)
        {
            var vacinaEntity = await _repository.GetById(id);
            return _mapper.Map<VacinaDTO>(vacinaEntity);
        }

        public async Task<IEnumerable<VacinaDTO>> GetVacinas()
        {
            var vacinaEntity = await _repository.GetVacinas();
            return _mapper.Map<IEnumerable<VacinaDTO>>(vacinaEntity);
        }

        public async Task Update(VacinaDTO vacina)
        {
            var vacinaEntity = _mapper.Map<Vacina>(vacina);
            await _repository.Update(vacinaEntity);
        }
    }
}
