using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ZooManagement;
using ZooManagement.Data;
using ZooManagement.Repositories;
using static ZooManagement.Repositories.IAnimalsRepo;
using static ZooManagement.Repositories.ISpeciesRepo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ZooManagementContext>(options =>
           {
               options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
               options.UseSqlite("Data Source=ZooManagement.db");
           });
builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "zoo", Version = "v1" });
            });

//Should go before the .Build() 
builder.Services.AddTransient<IAnimalsRepo, AnimalsRepo>();
builder.Services.AddTransient<ISpeciesRepo, SpeciesRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "zoo v1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

CreateDbIfNotExists(app);

app.Run();

static void CreateDbIfNotExists(IHost host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<ZooManagementContext>();
    context.Database.EnsureCreated();

    if (!context.Animals.Any())
    {
        var species = SpeciesList.GetSpecies();
        context.Species.AddRange(species);
        context.SaveChanges();

        var animals = SampleAnimals.GetAnimals();
        context.Animals.AddRange(animals);
        context.SaveChanges();
    }
}


