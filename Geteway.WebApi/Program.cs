using Ocelot.DependencyInjection;
using Ocelot.Middleware;

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("ocelot.json")
                            .Build();

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json");

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOcelot(configuration);

var app = builder.Build();
app.UseOcelot();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
