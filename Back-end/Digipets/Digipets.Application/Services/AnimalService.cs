using AutoMapper;
using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;

namespace Digipets.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private IAnimalRepository _repository;
        private readonly IMapper _mapper;
        public AnimalService(IAnimalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AnimalDTO> Create(AnimalDTO animal)
        {
            var animalEntity = _mapper.Map<Animal>(animal);
            return _mapper.Map<AnimalDTO>(await _repository.Create(animalEntity));
        }

        public async Task Delete(AnimalDTO animal)
        {
            var animalEntity = _mapper.Map<Animal>(animal);
            await _repository.Delete(animalEntity);
        }

        public async Task<IEnumerable<AnimalDTO>> GetAnimaisByTutorId(int id)
        {
            var animaisEntity = await _repository.GetAnimaisByTutorId(id);
            return _mapper.Map<IEnumerable<AnimalDTO>>(animaisEntity);
        }

        public async Task<AnimalDTO> GetById(int id)
        {
            var animalEntity = await _repository.GetById(id);
            return _mapper.Map<AnimalDTO>(animalEntity);
        }

        public async Task<AnimalDTO> Update(AnimalDTO animal)
        {
            var animalEntity = _mapper.Map<Animal>(animal);
            return _mapper.Map<AnimalDTO>(await _repository.Update(animalEntity));
        }
    }
}
