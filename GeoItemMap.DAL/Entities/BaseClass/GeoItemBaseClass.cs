using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities.BaseClass
{
    /// <summary>
    /// Базовый класс который хранит координаты точек 
    /// </summary>
    public class GeoItemBaseClass
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
        /// состояние (подумать над названием)
        /// </summary>
        public enum GeoItemType
        {
            Technopark,
            TechTransferCenter,
            InnProject,
            GNTPandRNTP
        }
    }
}
