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

     

        [HttpPost]
        public async Task<JsonResult> GetCoordinates()
        {
            IEnumerable<GeoItem> geoItems = await GeoItemGenericRepository.GetAllCoordinates();
            GeoItemsViewModel viewModel = new GeoItemsViewModel
            {
                GeoItems = geoItems
            };
            return Json(viewModel);
        }
        [HttpPost]
        public async Task<JsonResult> PostData()
        {

            IEnumerable<InnProject> InnProject = await InnProjectGenericRepository.GetAllCoordinates();
            IEnumerable<NtpProject> NtpProject = await NtpProjectGenericRepository.GetAllCoordinates();
            IEnumerable<Technopark> Technopark = await TechnoparkGenericRepository.GetAllCoordinates();
            IEnumerable<TechTransferCenter> TechTransferCenter = await TechTransferCenterGenericRepository.GetAllCoordinates();

            GeoItemsViewModel viewModel = new GeoItemsViewModel
            {

                InnProject = InnProject,
                NtpProject = NtpProject,
                Technopark = Technopark,
                TechTransferCenter = TechTransferCenter
            };

            return Json(viewModel);
        }
        // ИНН (отбор по id + вызов представления)
        public IActionResult GetPartialInnProject(int id)
        {
            List<InnProject> listInnProject = new();
            InnProject innProject = InnProjectGenericRepository.FindById(id);
            listInnProject.Add(innProject);
            GeoItemsViewModel viewModel = new GeoItemsViewModel { InnProject = listInnProject };
            return PartialView("_Partial.ShowInnProject", viewModel);
        }
        // НТП (отбор по id + вызов представления)
        public IActionResult GetPartialNtpProject(int id)
        {
            List<NtpProject> listNtpProject = new();
            NtpProject ntpProject = NtpProjectGenericRepository.FindById(id);
            listNtpProject.Add(ntpProject);
            GeoItemsViewModel viewModel = new GeoItemsViewModel { NtpProject = listNtpProject };
            return PartialView("_Partial.ShowNtpProject", viewModel);
        }
        // Технопарки (отбор по id + вызов представления)
        public IActionResult GetPartialTechParck(int id)
        {
            List<Technopark> listTechParck = new();
            Technopark technopark = TechnoparkGenericRepository.FindById(id);
            listTechParck.Add(technopark);
            GeoItemsViewModel viewModel = new GeoItemsViewModel { Technopark = listTechParck };
            return PartialView("_Partial.ShowTechParck", viewModel);
        }

        // ЦТТ (отбор по id + вызов представления)
        public IActionResult GetPartialCTT(int id)
        {

            List<TechTransferCenter> listCTT = new();
            TechTransferCenter techTransferCenter = TechTransferCenterGenericRepository.FindById(id);
            listCTT.Add(techTransferCenter);
            GeoItemsViewModel viewModel = new GeoItemsViewModel
            {
                TechTransferCenter = listCTT
            };

            return PartialView("_Partial.ShowCTT", viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}