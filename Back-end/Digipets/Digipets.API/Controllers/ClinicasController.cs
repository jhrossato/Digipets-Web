using Digipets.API.Context;
using Digipets.API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<IEnumerable<Clinica>> Get()
        {
            var clinicas = _context.TB_Clinicas.ToList();
            if(clinicas is null)
            {
                return NotFound();
            }
            return Ok(clinicas);
        }
    }
}
