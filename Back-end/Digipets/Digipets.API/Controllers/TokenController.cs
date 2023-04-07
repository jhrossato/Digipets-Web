using Digipets.API.Models;
using Digipets.Domain.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IAuthenticate _authentication;
        public TokenController(IAuthenticate authentication)
        {
            _authentication= authentication ??
                throw new ArgumentNullException(nameof(authentication));
        }
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel user)
        {
            var result = await _authentication.AuthenticateAsync(user.Email, user.Password);

            if (result)
                //return GenerateToken(user);
                return Ok($"usuario {user.Email} logado com sucesso!");
            else
            {
                ModelState.AddModelError(string.Empty, "Login inválido");
                return BadRequest(ModelState);
            }

                
        }
    }
}
