using Digipets.Domain.Interfaces;
using Digipets.Infra.Data.Context;
using Digipets.Infra.Data.Repositories;
using Digipets.Application.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Digipets.Application.Services;
using Digipets.Application.Interfaces;
using Microsoft.AspNetCore.Identity;
using Digipets.Domain.Account;
using Digipets.Infra.Data.Identity;

namespace Digipets.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            );

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IVeterinarioRepository, VeterinarioRepository>();
            services.AddScoped<ITutorRepository, TutorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IVacinaRepository, VacinaRepository>();
            services.AddScoped<IVacinaAplicadaRepository, VacinaAplicadaRepository>();
            services.AddScoped<IVeterinarioService, VeterinarioService>();
            services.AddScoped<ITutorService, TutorService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IVacinaService, VacinaService>();
            services.AddScoped<IVacinaAplicadaService, VacinaAplicadaService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedRoleInitial, SeedRoleInitial>();

            return services;
        }

        public static IServiceCollection AddSeed(ISeedRoleInitial seedRoleInitial)
        {

        }
    }
}
