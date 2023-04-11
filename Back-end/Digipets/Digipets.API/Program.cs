using Digipets.Infra.Data.Identity;
using Digipets.Infra.IoC;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddInfrastructureJWT(builder.Configuration);

builder.Services.AddInfrastructureSwagger();

var app = builder.Build();

SeedDatabase();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
        try
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            SeedRoleInitial seedRoleInitial = new SeedRoleInitial(roleManager);
            seedRoleInitial.SeedRoles();
        }
        catch
        {
            throw;
        }
}
    

app.UseCors(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyHeader()
           .AllowAnyMethod();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStatusCodePages();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
