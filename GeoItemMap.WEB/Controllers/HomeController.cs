using GeoItemMap.DAL.Entities;
using GeoItemMap.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GeoItemMap.DAL.Repositories;
using GeoItemMap.DAL.Interfaces;

namespace GeoItemMap.WEB.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IGenericRepository<GeoItem> GeoItemGenericRepository; 

        public HomeController(ILogger<HomeController> logger , IGenericRepository<GeoItem> _GeoItemGenericRepository)
        {
            _logger = logger;     
            GeoItemGenericRepository = _GeoItemGenericRepository;
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(GetMapYandexApi3));
        }

        public IActionResult GetMapYandexApi2()
        {
            return View();
        }

        public IActionResult GetMapYandexApi3()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}