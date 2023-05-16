using GeoItemMap.DAL.Entities;

namespace GeoItemMap.WEB.Models
{
    public class GeoItemViewModel
    {
        public IEnumerable<InnProject>? InnProjects { get; set; }
        public IEnumerable<NtpProject>? NtpProjects { get; set; }
        public IEnumerable <Technopark>? Technoparks { get; set; }

        public IEnumerable<TechTransferCenter>? TechTransferCenter { get; set;}
    }
}
