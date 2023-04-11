using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Application.Services;
using Digipets.Domain.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioService _veterinarioService;
        private readonly ITutorService _tutorService;
        private readonly IAuthenticate _authentication;
        public VeterinarioController(IVeterinarioService veterinarioService, ITutorService tutorService, IAuthenticate authentication)
        {
            _veterinarioService = veterinarioService;
            _tutorService = tutorService;
            _authentication = authentication;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VeterinarioDTO>>> GetAll()
        {
            var veterinarios = await _veterinarioService.GetVeterinarios();
            return Ok(veterinarios);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<VeterinarioDTO>> GetById(int id)
        {
            var veterinario = await _veterinarioService.GetById(id);
            return veterinario is null ? NotFound() : Ok(veterinario);

        }
        [HttpGet("{id:int}/Tutores")]
        public async Task<ActionResult<IEnumerable<TutorDTO>>> GetTutoresByVeterinarioId(int id)
        {
            var tutor = await _tutorService.GetTutoresByVeterinarioId(id);
            return tutor is null ? NotFound() : Ok(tutor);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<VeterinarioDTO>> Post(VeterinarioDTO veterinario)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _authentication.RegisterVeterinario(veterinario.Email, veterinario.Senha);

            if (result)
            {
                veterinario = await _veterinarioService.Create(veterinario);
                return new CreatedAtRouteResult(new { id = veterinario.Id }, veterinario);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Email ou senha inválido");
                return BadRequest(ModelState);
            }
        }
        [HttpPost("{id:int}/Tutores")]
        public async Task<ActionResult<TutorDTO>> PostNewTutor(int id, TutorDTO tutor)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            tutor.VeterinarioId = id;
            tutor = await _tutorService.Create(tutor);
            return new CreatedAtRouteResult(new { id = tutor.Id }, tutor);
        }
        [HttpPut]
        public async Task<ActionResult<VeterinarioDTO>> Put(VeterinarioDTO veterinario)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            if (veterinario.Id is 0)
                return BadRequest("O id não pode ser vazio");

            veterinario = await _veterinarioService.Update(veterinario);
            return new CreatedAtRouteResult(new { id = veterinario.Id }, veterinario);

        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var veterinario = await _veterinarioService.GetById(id);

            if (veterinario is not null)
            {
                await _veterinarioService.Delete(veterinario);
                return Ok();
            }
            else
                return NotFound();
        }
    }
}
