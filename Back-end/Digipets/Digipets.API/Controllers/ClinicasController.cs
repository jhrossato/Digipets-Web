using Digipets.API.Context;
using Digipets.API.Entities;
using Digipets.API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClinicasController : ControllerBase
    {
        private readonly DigipetsAPIContext _context;

        public ClinicasController(DigipetsAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clinica>>> Get()
        {
            try
            {
                var clinicas = await _context.Clinicas.ToListAsync();

                return Ok(clinicas);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Clinica>> Get(int id)
        {
            try
            {
                var result = await _context.Clinicas.Where(c => c.Id == id).FirstOrDefaultAsync();

                return result is null 
                    ? NotFound() 
                    : result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Clinica>> Post([FromBody]CreateClinicaViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var clinica = new Clinica
            {
                Nome = model.Nome,
                CRMV = model.CRMV,
                CNPJ = model.CNPJ,
                MAPA = model.MAPA,
                Telefone = model.Telefone,
                Email = model.Email,
                Endereco = new Endereco
                {
                    Rua = model.Endereco.Rua,
                    Numero = model.Endereco.Numero,
                    Bairro = model.Endereco.Bairro,
                    Cidade = model.Endereco.Cidade,
                    CEP = model.Endereco.CEP,
                },
                Admin = new Admin
                {
                    Nome = model.Admin.Nome,
                    Email = model.Admin.Email,
                    Senha = model.Admin.Senha,
                }
            };

            _context.Clinicas.Add(clinica);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = clinica.Id }, clinica);

        }
    }
}
