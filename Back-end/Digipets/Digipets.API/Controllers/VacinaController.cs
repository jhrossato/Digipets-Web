using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VacinaController : Controller
    {
        private readonly IVacinaService _vacinaService;
        public VacinaController (IVacinaService vacinaService)
        {
            _vacinaService = vacinaService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VacinaDTO>>> GetAll()
        {
            var vacinas = await _vacinaService.GetVacinas();
            return Ok(vacinas);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<VacinaDTO>> GetById(int id)
        {
            var vacina = await _vacinaService.GetById(id);
            return vacina is null ? NotFound() : Ok(vacina);

        }
        [HttpPost]
        public async Task<ActionResult<VacinaDTO>> Post(VacinaDTO vacina)
        {
            if (vacina is null)
                return BadRequest();

            await _vacinaService.Create(vacina);
            return new CreatedAtRouteResult(new { id = vacina.Id }, vacina);
        }
        [HttpPut]
        public async Task<ActionResult<VacinaDTO>> Put(VacinaDTO vacina)
        {
            if (vacina is null)
                return BadRequest();

            await _vacinaService.Update(vacina);
            return new CreatedAtRouteResult(new { id = vacina.Id }, vacina);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vacina = await _vacinaService.GetById(id);

            if (vacina is not null)
            {
                await _vacinaService.Delete(vacina);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
