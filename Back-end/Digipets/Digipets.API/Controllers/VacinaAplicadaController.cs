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
        [HttpPut("{id:int}")]
        public async Task<ActionResult<VacinaAplicadaDTO>> Put(int id, VacinaAplicadaDTO vacinaAplicada)
        {
            if (vacinaAplicada is null)
                return BadRequest();

            if (id is 0)
                return BadRequest("O id não pode ser vazio");

            VacinaAplicadaDetailsDTO vacinaAplicadaDetails = new();
            vacinaAplicadaDetails = await _vacinaAplicadaService.Update(vacinaAplicada);
            return new CreatedAtRouteResult(new { id = vacinaAplicadaDetails.Id }, vacinaAplicadaDetails);

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
