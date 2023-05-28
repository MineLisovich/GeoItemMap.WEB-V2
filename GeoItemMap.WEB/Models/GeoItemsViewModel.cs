using GeoItemMap.DAL.Entities;

namespace GeoItemMap.WEB.Models
{
    public class GeoItemsViewModel
    {
        public IEnumerable<GeoItem> GeoItems { get; set; }
        public IEnumerable<InnProject> InnProject { get; set; }
        public IEnumerable<NtpProject> NtpProject { get; set; }
        public IEnumerable<Technopark> Technopark { get; set; }
        public IEnumerable<TechTransferCenter> TechTransferCenter { get; set; }
    }
}
