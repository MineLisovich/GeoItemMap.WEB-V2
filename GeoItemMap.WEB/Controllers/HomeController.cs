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
        private IGenericRepository<InnProject> InnProjectGenericRepository;
        private IGenericRepository<NtpProject> NtpProjectGenericRepository;
        private IGenericRepository<Technopark> TechnoparkGenericRepository;
        private IGenericRepository<TechTransferCenter> TechTransferCenterGenericRepository;


        public HomeController(ILogger<HomeController> logger, 
            IGenericRepository<GeoItem> _GeoItemGenericRepository,
            IGenericRepository<InnProject> _InnProjectGenericRepository,
            IGenericRepository<NtpProject> _NtpProjectGenericRepository,
            IGenericRepository<Technopark> _TechnoparkGenericRepository,
            IGenericRepository<TechTransferCenter> _TechTransferCenterGenericRepository)
        {
            _logger = logger;
            GeoItemGenericRepository = _GeoItemGenericRepository;
            InnProjectGenericRepository = _InnProjectGenericRepository;
            NtpProjectGenericRepository = _NtpProjectGenericRepository;
            TechnoparkGenericRepository = _TechnoparkGenericRepository;
            TechTransferCenterGenericRepository = _TechTransferCenterGenericRepository;
        }

        public IActionResult Index()
        {
            return View();  
           
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
        public IActionResult testPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> PostData()
        {
            IEnumerable<GeoItem> GeoItem = await GeoItemGenericRepository.GetAllCoordinates();
            IEnumerable<InnProject> InnProject = await InnProjectGenericRepository.GetAllCoordinates();
            IEnumerable<NtpProject> NtpProject = await NtpProjectGenericRepository.GetAllCoordinates();
            IEnumerable<Technopark> Technopark = await TechnoparkGenericRepository.GetAllCoordinates();
            IEnumerable<TechTransferCenter> TechTransferCenter = await TechTransferCenterGenericRepository.GetAllCoordinates();

            GeoItemsViewModel viewModel = new GeoItemsViewModel 
            { 
                GeoItems = GeoItem,
                InnProject = InnProject,
                NtpProject = NtpProject,
                Technopark = Technopark,
                TechTransferCenter = TechTransferCenter
            };

            return Json(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}