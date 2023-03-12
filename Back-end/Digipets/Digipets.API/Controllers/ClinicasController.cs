using Digipets.API.Context;
using Digipets.API.Entities;
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
                var clinicas = await _context.TB_Clinicas.ToListAsync();
                
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
                var result = await _context.TB_Clinicas.Where(c => c.Id == id).FirstOrDefaultAsync();
              
                return result is null ? NotFound() : result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Clinica clinica)
        {
            try
            {
                await _context.TB_Clinicas.AddAsync(clinica);
                await _context.SaveChangesAsync();

                return StatusCode(StatusCodes.Status201Created);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
