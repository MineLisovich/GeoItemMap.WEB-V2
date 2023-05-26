using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.Interfaces;
using GeoItemMap.WEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeoItemMap.WEB.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GeoItemController : ControllerBase
    {
        private IGenericRepository<GeoItem> GeoItemGenericRepository;
        public GeoItemController(IGenericRepository<GeoItem> _GeoItemGenericRepository)
        {
            GeoItemGenericRepository = _GeoItemGenericRepository;
        }

        // GET: /GeoItem
        [HttpGet]
        public async Task<IEnumerable<GeoItem>> GetGeoCoordinates()
        {
            IEnumerable<GeoItem> model = await GeoItemGenericRepository.GetAllCoordinates();
            return model;
        }

        // GET: /GeoItem/1
        [HttpGet("{id}")]
        public IResult GetGeoItem(int id)
        {
            var geoItemObject = GeoItemGenericRepository.FindById(id);
            if (geoItemObject == null) return Results.NotFound(new { message = "Геообъект не найден" });
            return Results.Json(geoItemObject);
        }

  
    }
}
