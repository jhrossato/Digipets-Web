﻿using Digipets.Application.DTOs;
using Digipets.Application.Interfaces;
using Digipets.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioService _veterinarioService;
        private readonly ITutorService _tutorService;
        public VeterinarioController(IVeterinarioService veterinarioService, ITutorService tutorService)
        {
            _veterinarioService = veterinarioService;
            _tutorService = tutorService;
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
        public async Task<ActionResult<VeterinarioDTO>> Post(VeterinarioDTO veterinario)
        {
            if (veterinario is null)
                return BadRequest();

            await _veterinarioService.Create(veterinario);
            return new CreatedAtRouteResult(new { id = veterinario.Id }, veterinario);
        }
        [HttpPost("{id:int}/Tutores")]
        public async Task<ActionResult<TutorDTO>> PostNewTutor(int id, TutorDTO tutor)
        {
            if (tutor is null)
                return BadRequest();
            tutor.VeterinarioId = id;
            await _tutorService.Create(tutor);
            return new CreatedAtRouteResult(new { id = tutor.Id }, tutor);
        }
        [HttpPut]
        public async Task<ActionResult<VeterinarioDTO>> Put(VeterinarioDTO veterinario)
        {
            if (veterinario is null)
                return BadRequest();

            await _veterinarioService.Update(veterinario);
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
