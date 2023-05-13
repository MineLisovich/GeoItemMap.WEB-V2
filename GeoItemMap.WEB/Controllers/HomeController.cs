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

        private IGenericRepository<GeoItem> genericRepository;
        public HomeController(ILogger<HomeController> logger , IGenericRepository<GeoItem> _genericRepository)
        {
            _logger = logger;
            // this.genericRepository = new EFGenericRepository<GeoItem>();
            genericRepository = _genericRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> PostData()
        {
           var model = await genericRepository.GetAll();
            return Json(model);
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