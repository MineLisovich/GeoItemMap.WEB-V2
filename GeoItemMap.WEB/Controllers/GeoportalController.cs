using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.Interfaces;
using GeoItemMap.WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GeoItemMap.WEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoportalController : ControllerBase
    {
        private readonly IGenericRepository<GeoItem> genericRepository;
        private readonly IGenericRepository<InnProject> innProjactRepository;
        private readonly IGenericRepository<NtpProject> ntpProjactRepository;
        private readonly IGenericRepository<Technopark> technoparkRepository;
        private readonly IGenericRepository<TechTransferCenter> techtransferCenterRepository;

        public GeoportalController(IGenericRepository<GeoItem> _genericRepository,
         IGenericRepository<InnProject> _innProjactRepository,
         IGenericRepository<NtpProject> _ntpProjactRepository,
         IGenericRepository<Technopark> _technoparkRepository,
         IGenericRepository<TechTransferCenter> _techtransferCenterRepository)
        {
            genericRepository = _genericRepository;
            innProjactRepository = _innProjactRepository;
            ntpProjactRepository = _ntpProjactRepository;
            technoparkRepository = _technoparkRepository;
            techtransferCenterRepository = _techtransferCenterRepository;
        }

        //[HttpGet]
        //public async Task <IEnumerable<GeoItem>> GetGeoCoordinats()
        //{
        //    IEnumerable<GeoItem> geoItems = await genericRepository.GetAllCoordinates();
        //    return geoItems;
        //}

        [HttpPost]
        public async Task <IResult> GetAllDataGeoItems()
        {
            IEnumerable<InnProject> InnProject = await innProjactRepository.GetAllCoordinates();
            IEnumerable<NtpProject> NtpProject = await ntpProjactRepository.GetAllCoordinates();
            IEnumerable<Technopark> Technopark = await technoparkRepository.GetAllCoordinates();
            IEnumerable<TechTransferCenter> TechTransferCenter = await techtransferCenterRepository.GetAllCoordinates();

            GeoItemsViewModel viewModel = new GeoItemsViewModel
            {
                InnProject = InnProject,
                NtpProject = NtpProject,
                Technopark = Technopark,
                TechTransferCenter = TechTransferCenter
            };
            return Results.Json(viewModel);
        }

        [HttpGet("{id}")]
        public IResult GetDataGeoItemsById(int id)
        {
           GeoItem geoItems = genericRepository.FindById(id);
           if (geoItems == null)
            {
                return Results.NotFound(new {message = "Geoitem not found"});
            }
           return Results.Json(geoItems);  
        }


        //
        [HttpGet]
        public IActionResult TemporaryPages()
        {
            
            return RedirectToAction("TemporaryPages", "Home");
        }
    }
}
