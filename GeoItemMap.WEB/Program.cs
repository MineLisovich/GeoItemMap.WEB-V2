using GeoItemMap.DAL.Interfaces;
using GeoItemMap.DAL.Repositories;
using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.DataContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using GeoItemMap.WEB.Service;


var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("https://localhost:7215", "http://localhost:5003");
           
        });
});

var configuration = builder.Configuration;
configuration.Bind("ConnectionString", new Config());
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IGenericRepository<GeoItem>, EFGenericRepository<GeoItem>>();
builder.Services.AddScoped<IGenericRepository<Technopark>, EFGenericRepository<Technopark>>();
builder.Services.AddScoped<IGenericRepository<InnProject>, EFGenericRepository<InnProject>>();
builder.Services.AddScoped<IGenericRepository<NtpProject>, EFGenericRepository<NtpProject>>();
builder.Services.AddScoped<IGenericRepository<TechTransferCenter>, EFGenericRepository<TechTransferCenter>>();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.DefaultConnection));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
