using GeoItemMap.DAL.Predefined;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeoItemMap.DAL.Predefined.RegionTypeEnum;

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

        /// <summary>
        /// Тип объекта
        /// </summary>
        [Required]
        public GeoItemType GeoType { get; set; }
        /// <summary>
        /// Региональная принадлежность объекта
        /// </summary>
        [Required]
        public RegionType Region { get; set; }
        /// <summary>
        /// Статус ИНН (1-Завершено;2-Выполняется;3-План)
        /// </summary>
        public short statusInn { get; set; }
        /// <summary>
        /// Статус НТП (1-Завершено;2-Выполняется;3-План)
        /// </summary>
        public short statusNtp { get; set; }

    }
}
