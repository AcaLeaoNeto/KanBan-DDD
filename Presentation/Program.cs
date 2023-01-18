global using Domain.Interfaces.Service;
global using Domain.Services;
global using Infrastructure.Context;

using Presentation.Configurations.Dependencys;
using Infrastructure.Repository;
using Domain.Interfaces.Repository;

using Presentation.Configurations.Dependencys.Repository;
using Presentation.Configurations.Dependencys.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .DependencyRepository()
    .DependencyServices();

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddDbContext<DbContent>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
