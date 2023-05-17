using GeoItemMap.DAL.Predefined;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities
{
    public class GeoItem
    {
        public int Id { get; set; }
        /// <summary>
        /// Широта
        /// </summary>
        [Required]
        public float X { get; set; }
        /// <summary>
        /// Долгота
        /// </summary>
        [Required]
        public float Y { get; set; }
        
        public GeoItemType GeoType { get; set; }
    }
}
