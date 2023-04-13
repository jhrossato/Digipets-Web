using Digipets.API.Models;
using Digipets.Domain.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Digipets.Application.Interfaces;
using Digipets.Application.DTOs;

namespace Digipets.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IAuthenticate _authentication;
        private readonly IConfiguration _configuration;
        private readonly IVeterinarioService _veterinarioService;

        public TokenController(IAuthenticate authentication, IConfiguration configuration, IVeterinarioService veterinarioService)
        {
            _authentication= authentication ??
                throw new ArgumentNullException(nameof(authentication));
            _configuration = configuration;
            _veterinarioService = veterinarioService;
        }
        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] LoginModel user)
        {
            var result = await _authentication.AuthenticateAsync(user.Email, user.Password);

            if (result)
            {
                var veterinarios = _veterinarioService.GetVeterinarios().Result;
                var veterinario = veterinarios.Where(v => v.Email == user.Email).FirstOrDefault();
                user.Id = veterinario.Id;

                return GenerateToken(user);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Login inválido");
                return BadRequest(ModelState);
            }                
        }

        private UserToken GenerateToken(LoginModel user)
        {
            var claims = new[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim("email", user.Email),
                new Claim("valor", "5fFLk6NQ0W5&"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };

            var privateKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_configuration["Jwt:SecretKey"])
                );

            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(15);

            JwtSecurityToken token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: expiration,
                    signingCredentials: credentials
                );

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}
