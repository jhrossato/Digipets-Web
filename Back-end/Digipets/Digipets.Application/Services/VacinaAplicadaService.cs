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
        public async Task<VacinaAplicadaDetailsDTO> Create(VacinaAplicadaDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            return _mapper.Map<VacinaAplicadaDetailsDTO>(await _repository.Create(vacinaAplicadaEntity));
        }

        public async Task Delete(VacinaAplicadaDetailsDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            await _repository.Delete(vacinaAplicadaEntity);
        }

        public async Task<VacinaAplicadaDetailsDTO> GetById(int id)
        {
            var vacinaAplicadaEntity = await _repository.GetById(id);
            return _mapper.Map<VacinaAplicadaDetailsDTO>(vacinaAplicadaEntity);
        }

        public async Task<IEnumerable<VacinaAplicadaDetailsDTO>> GetVacinasByAnimalId(int id)
        {
            var vacinaAplicadaEntity = await _repository.GetVacinasByAnimalId(id);
            return _mapper.Map<IEnumerable<VacinaAplicadaDetailsDTO>>(vacinaAplicadaEntity);
        }

        public async Task<VacinaAplicadaDetailsDTO> Update(VacinaAplicadaDTO vacina)
        {
            var vacinaAplicadaEntity = _mapper.Map<VacinaAplicada>(vacina);
            return _mapper.Map<VacinaAplicadaDetailsDTO>(await _repository.Update(vacinaAplicadaEntity));
        }
    }
}
