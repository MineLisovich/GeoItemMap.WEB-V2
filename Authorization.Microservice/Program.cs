using Authorization.Microservice.Domain;
using Authorization.Microservice.Domain.Repositories;
using Authorization.Microservice.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
configuration.Bind("ConnectionString", new Config());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUsersRepository, EFUserRepository>();
builder.Services.AddDbContext<AuthorizationDbContext>(x => x.UseSqlServer(Config.DefaultConnection));
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
