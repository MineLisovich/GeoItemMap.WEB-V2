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
        private IGenericRepository<Technopark> TechnoparkGenericRepository;
        private IGenericRepository<InnProject> InnProgectGenericRepository;
        private IGenericRepository<NtpProject> NtpProjectGenericRepository;
        private IGenericRepository<TechTransferCenter> TechTransferCenterGenericRepository;

        public HomeController(ILogger<HomeController> logger , IGenericRepository<GeoItem> _GeoItemGenericRepository, 
            IGenericRepository<Technopark> _TechnoparkGenericRepository, IGenericRepository<InnProject> _InnGenericRepository,
            IGenericRepository<NtpProject> _NtpGenericRepository, IGenericRepository<TechTransferCenter> _TTCgenericRepository)
        {
            _logger = logger;     
            GeoItemGenericRepository = _GeoItemGenericRepository;
            TechnoparkGenericRepository = _TechnoparkGenericRepository;
            InnProgectGenericRepository = _InnGenericRepository;
            NtpProjectGenericRepository = _NtpGenericRepository;
            TechTransferCenterGenericRepository = _TTCgenericRepository;
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


        [HttpPost]
        public async Task<JsonResult> PostData()
        {
           var model = await GeoItemGenericRepository.GetAll();
            return Json(model);
        }

        [HttpGet]
        public async Task <IEnumerable<GeoItem>> GetGeoCoordinates()
        {
            IEnumerable<GeoItem> model = await GeoItemGenericRepository.GetAll(); 
            return model;
        }

        [HttpPost]
        public async Task<JsonResult> GetAllData ()
        {  
            var innProj = await InnProgectGenericRepository.GetAll();
            var ntpProj = await NtpProjectGenericRepository.GetAll();
            var tehPark = await TechnoparkGenericRepository.GetAll();
            var ttc = await TechTransferCenterGenericRepository.GetAll();   
            GeoItemViewModel geoItemViewModel = new GeoItemViewModel
            {
                InnProjects = innProj,
                NtpProjects = ntpProj,
                Technoparks = tehPark,
                TechTransferCenter = ttc
            };
            return Json(geoItemViewModel);  
        }

        //[HttpGet]
        //public async Task<IEnumerable<Technopark>> GetGeoItems()
        //{
        //    IEnumerable<Technopark> model = await TechnoparkGenericRepository.GetAll();

            
        //    return model;
        //}


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