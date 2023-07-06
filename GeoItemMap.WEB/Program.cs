using GeoItemMap.DAL.Interfaces;
using GeoItemMap.DAL.Repositories;
using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.DataContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using GeoItemMap.WEB.Service;
using System.Net;
using Microsoft.AspNetCore.HttpOverrides;

var builder = WebApplication.CreateBuilder(args);


// Configure forwarded headers
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.KnownProxies.Add(IPAddress.Parse("10.10.0.15"));

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
else
{
    app.UseForwardedHeaders(new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
    });
    app.UseForwardedHeaders();
}

app.UseStaticFiles();
//app.UseHttpsRedirection();
app.UseRouting();
//app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
