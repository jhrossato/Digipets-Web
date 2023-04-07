using Digipets.Domain.Account;
using Microsoft.AspNetCore.Identity;

namespace Digipets.Infra.Data.Identity
{
    public class SeedRoleInitial : ISeedRoleInitial
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedRoleInitial(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public void SeedRoles()
        {

            if (!_roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }

            if (!_roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                IdentityResult roleResult = _roleManager.CreateAsync(role).Result;
            }
        }
    }
}
