using Microsoft.EntityFrameworkCore;
using practica0.Data;
using practica0.Mappings;
using practica0.Repositories;
using practica0.Repositories.Impl;
using practica0.Services;
using practica0.Services.Impl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBD>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDatabase")));

builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(conf =>
    {
        conf.AllowAnyHeader();
        conf.AllowAnyMethod();
        conf.AllowAnyOrigin();
    });
});

builder.Services.AddScoped<RepoRepository,RepoRepositoryImpl>();
builder.Services.AddScoped<OperacionesService,OperacionesServiceImpl>();

builder.Services.AddAutoMapper(typeof(MapperClass));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
