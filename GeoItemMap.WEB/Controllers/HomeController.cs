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

     

        public HomeController(ILogger<HomeController> logger )
        {
            _logger = logger;     
        }

        public IActionResult Index()
        {
            return View();  
           // return RedirectToAction(nameof(GetMapYandexApi2));
        }

        public IActionResult GetMapYandexApi2()
        {
            return View();
        }

        public IActionResult GetMapYandexApi3()
        {
            return View();
        }

        public IActionResult TESTGetMapYandexApi3()
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