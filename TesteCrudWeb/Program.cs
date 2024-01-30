using Microsoft.Extensions.Configuration;
using TesteCrudData.Repository;
using Microsoft.EntityFrameworkCore;
using TesteCrudDomain.Interface;
using TesteCrudDomain.Services;
using TesteCrudData.Interface;
using AutoMapper;
using TesteCrudModels.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserService, UserSerivce>();
builder.Services.AddScoped<IUserRepository, UserRepository>();




var configuration = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<UserEntity, UserView>();
    cfg.CreateMap<UserView, UserEntity>();
});

var mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddDbContext<RepositoryContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
