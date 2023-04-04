using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AnimalController : Controller
    {
        private readonly IAnimalService _animalService;
        private readonly IVacinaAplicadaService _vacinaAplicadaService;
        public AnimalController(IAnimalService animalService, IVacinaAplicadaService vacinaAplicadaService)
        {
            _animalService = animalService;
            _vacinaAplicadaService = vacinaAplicadaService;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<AnimalDTO>> GetById(int id)
        {
            var animal = await _animalService.GetById(id);
            return animal is null ? NotFound() : Ok(animal);

        }
        [HttpPut]
        public async Task<ActionResult<AnimalDTO>> Put(AnimalDTO animal)
        {
            if (animal is null)
                return BadRequest();

            await _animalService.Update(animal);
            return new CreatedAtRouteResult(new { id = animal.Id }, animal);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var animal = await _animalService.GetById(id);

            if (animal is not null)
            {
                await _animalService.Delete(animal);
                return Ok();
            }
            else
                return NotFound();
        }
        [HttpGet("{id:int}/Vacinas")]
        public async Task<ActionResult<IEnumerable<VacinaAplicadaDTO>>> GetVacinasByAnimalId(int id)
        {
            var vacinas = await _vacinaAplicadaService.GetVacinasByAnimalId(id);
            return vacinas is null ? NotFound() : Ok(vacinas);
        }
        [HttpPost("{id:int}/Vacinas")]
        public async Task<ActionResult<VacinaAplicadaDTO>> PostNewVacina(int id, VacinaAplicadaDTO vacina)
        {
            if (vacina is null)
                return BadRequest();
            vacina.AnimalId = id;
            await _vacinaAplicadaService.Create(vacina);
            return new CreatedAtRouteResult(new { id = vacina.Id }, vacina);
        }
    }
}
