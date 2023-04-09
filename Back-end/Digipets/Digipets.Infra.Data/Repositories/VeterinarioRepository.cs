using Digipets.Domain.Entities;
using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Digipets.Infra.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Digipets.Infra.Data.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public VeterinarioRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<Veterinario> Create(Veterinario veterinario)
        {
            try
            {
                if (_userManager.FindByEmailAsync(veterinario.Email).Result is null)
                {
                    ApplicationUser user = new ApplicationUser()
                    {
                        UserName = veterinario.Email,
                        Email = veterinario.Email,
                        NormalizedUserName = veterinario.Email.ToUpper(),
                        NormalizedEmail = veterinario.Email.ToUpper(),
                        EmailConfirmed = true,
                        LockoutEnabled = false,
                        SecurityStamp = Guid.NewGuid().ToString()
                    };
                    IdentityResult result = await _userManager.CreateAsync(user, veterinario.Senha);

                    if (result.Succeeded)
                        _userManager.AddToRoleAsync(user, "Admin").Wait();

                    _context.Add(veterinario);
                    await _context.SaveChangesAsync();
                    return veterinario;
                }
                return null;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<bool> Delete(Veterinario veterinario)
        {
            try
            {
                _context.Remove(veterinario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }

        public async Task<Veterinario> GetById(int id)
        {
            return await _context.veterinarios.Include(v => v.Endereco).AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Veterinario>> GetVeterinarios()
        {
            return await _context.veterinarios.Include(v => v.Endereco).AsNoTracking().ToListAsync();
        }

        public async Task<Veterinario> Update(Veterinario veterinario)
        {

            try
            {
                var veterinarioAux = await _context.veterinarios.AsNoTracking().FirstOrDefaultAsync(v => v.Id == veterinario.Id);
                if (veterinarioAux.Email == veterinario.Email && veterinarioAux.Senha == veterinario.Senha)
                {
                    _context.Update(veterinario);
                    await _context.SaveChangesAsync();
                    return veterinario;
                }
                else
                {
                    if (_userManager.FindByEmailAsync(veterinario.Email).Result is null)
                    {
                        ApplicationUser user = new ApplicationUser()
                        {
                            UserName = veterinario.Nome,
                            Email = veterinario.Email,
                            NormalizedUserName = veterinario.Nome.ToUpper(),
                            NormalizedEmail = veterinario.Email.ToUpper(),
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            SecurityStamp = Guid.NewGuid().ToString()
                        };
                        IdentityResult result = await _userManager.UpdateAsync(user);
                        if (veterinario.Senha is not null)
                        {
                            result = await _userManager.ChangePasswordAsync(user, veterinarioAux.Senha, veterinario.Senha);
                        }
                        if (result.Succeeded)
                        {
                            _context.Update(veterinario);
                            await _context.SaveChangesAsync();
                            return veterinario;
                        }

                    }

                }
                return null;
            }
            catch (DbUpdateException ex)
            {
                throw new DbUpdateException(ex.Message, ex);
            }
        }
    }
}
