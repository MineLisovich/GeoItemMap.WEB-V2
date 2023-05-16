using GeoItemMap.DAL.Interfaces;
using GeoItemMap.DAL.Repositories;
using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.DataContext;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IGenericRepository<GeoItem>, EFGenericRepository<GeoItem>>();
builder.Services.AddScoped<IGenericRepository<Technopark>, EFGenericRepository<Technopark>>();
builder.Services.AddScoped<IGenericRepository<InnProject>, EFGenericRepository<InnProject>>();
builder.Services.AddScoped<IGenericRepository<NtpProject>, EFGenericRepository<NtpProject>>();
builder.Services.AddScoped<IGenericRepository<TechTransferCenter>, EFGenericRepository<TechTransferCenter>>();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(@"Data Source=PC11-1203-3N\SQLEXPRESS;  Database=GeoItemDB;  Persist Security Info =false; User='sa'; Password='sa'; MultipleActiveResultSets=True; Trusted_Connection=False;"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
