using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class TutorController : Controller
    {
        private readonly ITutorService _tutorService;
        private readonly IAnimalService _animalService;
        public TutorController(ITutorService tutorService, IAnimalService animalService)
        {
            _tutorService = tutorService;
            _animalService = animalService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TutorDTO>>> GetAll()
        {
            var tutores = await _tutorService.GetTutores();
            return Ok(tutores);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TutorDTO>> GetById(int id)
        {
            var tutor = await _tutorService.GetById(id);
            return tutor is null ? NotFound() : Ok(tutor);

        }
        [HttpPut]
        public async Task<ActionResult<TutorDTO>> Put(TutorDTO tutor)
        {
            if (tutor is null)
                return BadRequest();

            if (tutor.Id is 0)
                return BadRequest("O id não pode ser vazio");

            tutor = await _tutorService.Update(tutor);
            return new CreatedAtRouteResult(new { id = tutor.Id }, tutor);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var tutor = await _tutorService.GetById(id);

            if (tutor is not null)
            {
                await _tutorService.Delete(tutor);
                return Ok();
            }
            else
                return NotFound();
        }
        [HttpGet("{id:int}/Animais")]
        public async Task<ActionResult<IEnumerable<AnimalDTO>>> GetAnimaisByTutorId(int id)
        {
            var animais = await _animalService.GetAnimaisByTutorId(id);
            return animais is null ? NotFound() : Ok(animais);
        }
        [HttpPost("{id:int}/Animais")]
        public async Task<ActionResult<TutorDTO>> PostNewAnimal(int id, AnimalDTO animal)
        {
            if (animal is null)
                return BadRequest();
            animal.TutorId = id;
            animal = await _animalService.Create(animal);
            return new CreatedAtRouteResult(new { id = animal.Id }, animal);
        }
    }
}
