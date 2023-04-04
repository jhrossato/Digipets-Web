using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digipets.Application.Services
{
    public class VacinaAplicadaService : IVacinaAplicadaService
    {
        private IVacinaAplicadaRepository _repository;
        private readonly IMapper _mapper;
        public VacinaAplicadaService(IVacinaAplicadaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(VacinaAplicadaDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            await _repository.Create(vacinaAplicadaEntity);
        }

        public async Task Delete(VacinaAplicadaDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            await _repository.Delete(vacinaAplicadaEntity);
        }

        public async Task<VacinaAplicadaDTO> GetById(int id)
        {
            var vacinaAplicadaEntity = await _repository.GetById(id);
            return _mapper.Map<VacinaAplicadaDTO>(vacinaAplicadaEntity);
        }

        public async Task<IEnumerable<VacinaAplicadaDTO>> GetVacinasByAnimalId(int id)
        {
            var vacinaAplicadaEntity = await _repository.GetVacinasByAnimalId(id);
            return _mapper.Map<IEnumerable<VacinaAplicadaDTO>>(vacinaAplicadaEntity);
        }

        public async Task Update(VacinaAplicadaDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            await _repository.Update(vacinaAplicadaEntity);
        }
    }
}
