using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VacinaAplicadaController : Controller
    {
        private readonly IVacinaAplicadaService _vacinaAplicadaService;
        public VacinaAplicadaController(IVacinaAplicadaService vacinaAplicadaService)
        {
            _vacinaAplicadaService = vacinaAplicadaService;
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<VacinaAplicadaDTO>> GetById(int id)
        {
            var vacinaAplicada = await _vacinaAplicadaService.GetById(id);
            return vacinaAplicada is null ? NotFound() : Ok(vacinaAplicada);

        }
        [HttpPut]
        public async Task<ActionResult<VacinaAplicadaDTO>> Put(VacinaAplicadaDTO vacinaAplicada)
        {
            if (vacinaAplicada is null)
                return BadRequest();

            await _vacinaAplicadaService.Update(vacinaAplicada);
            return new CreatedAtRouteResult(new { id = vacinaAplicada.Id }, vacinaAplicada);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var vacinaAplicada = await _vacinaAplicadaService.GetById(id);

            if (vacinaAplicada is not null)
            {
                await _vacinaAplicadaService.Delete(vacinaAplicada);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
