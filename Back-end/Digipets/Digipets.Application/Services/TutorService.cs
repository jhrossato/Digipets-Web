using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;

namespace Digipets.Application.Services
{
    public class TutorService : ITutorService
    {
        private ITutorRepository _repository;
        private readonly IMapper _mapper;
        public TutorService(ITutorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TutorDTO> Create(TutorDTO tutor)
        {
            var tutorEntity = _mapper.Map<Tutor>(tutor);
            return _mapper.Map<TutorDTO>(await _repository.Create(tutorEntity));
        }

        public async Task Delete(TutorDTO tutor)
        {
            var tutorEntity = _mapper.Map<Tutor>(tutor);
            await _repository.Delete(tutorEntity);
        }

        public async Task<TutorDTO> GetById(int id)
        {
            var tutorEntity = await _repository.GetById(id);
            return _mapper.Map<TutorDTO>(tutorEntity);
        }

        public async Task<IEnumerable<TutorDTO>> GetTutores()
        {
            var tutoresEntity = await _repository.GetTutores();
            return _mapper.Map<IEnumerable<TutorDTO>>(tutoresEntity);
        }

        public async Task<IEnumerable<TutorDTO>> GetTutoresByVeterinarioId(int id)
        {
            var tutoresEntity = await _repository.GetTutoresByVeterinarioId(id);
            return _mapper.Map<IEnumerable<TutorDTO>>(tutoresEntity);
        }

        public async Task<TutorDTO> Update(TutorDTO tutor)
        {
            var tutoresEntity = _mapper.Map<Tutor>(tutor);
            return _mapper.Map<TutorDTO>(await _repository.Update(tutoresEntity));
        }
    }
}
