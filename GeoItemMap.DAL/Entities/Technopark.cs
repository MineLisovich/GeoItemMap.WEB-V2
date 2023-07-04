using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities
{
    public class Technopark : GeoItem
    {
        /// <summary>
        /// Наименование технопарка
        /// </summary>
        [Required]
      //  [StringLength(250)]
        public string? NameTechnopark { get; set; }

        /// <summary>
        /// Адрес технопарка
        /// </summary>
        [Required]
     //   [StringLength(250)]
        public string? AddressTechnopark { get; set; }

        /// <summary>
        /// Контактыне данные технопарка
        /// </summary>
        [Required]
      //  [StringLength(100)]
        public string? PhoneTechnopark { get; set; }

        /// <summary>
        /// Электронная почта технопарка
        /// </summary>
        [Required]
      //  [StringLength(50)]
        public string? EmailTechnopark { get; set; }

        /// <summary>
        /// Сайт технопарка
        /// </summary>
        [Required]
      //  [StringLength(50)]
        public string? WebsiteTechnopark { get; set; }

        /// <summary>
        /// Общая площадь помещений, м^2
        /// </summary>
        [Required]
        public float TotalAreaPremises { get; set; }

        /// <summary>
        /// Свободная площадь помещений, м^2
        /// </summary>
        [Required]
        public float FreeAreaPremises { get; set; }

        /// <summary>
        /// Специализация технопарка 
        /// </summary>
        [Required]
     //   [StringLength (100)]
        public string? TechSpecialization { get; set; }

        /// <summary>
        /// Ключевые виды продукции резидентов технопарка
        /// </summary>
        [Required]
     //   [StringLength(250)]
        public string? TypesProducts { get; set; }

        /// <summary>
        /// Услуги, предоставляемые технопарком резиденту 
        /// </summary>
        [Required]
       // [StringLength(250)]
        public string? ServicesProvided { get; set; }

        /// <summary>
        /// Технологическая инфраструктура технопарка, технологическое оборудование
        /// </summary>
        [Required]
      //  [StringLength(250)]
        public string? TechInfrastructure { get; set; }
        /// <summary>
        /// Общее количество резидентов технопарка, ед
        /// </summary>
       // [Required]
        public short? TotalNumberResident { get; set; }

        /// <summary>
        /// Количество работников резидентов технопарка 
        /// </summary>
        [Required]
        public short? NumberEmployees { get; set; }

        /// <summary>
        /// Объем отгруженной (выполненной) резидентами технопарка продукции (работ, услуг)
        /// </summary>
        [Required]
        public float? VolComplProducts { get; set; }

        /// <summary>
        /// Объем финансирования
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? AmountFunding { get; set; }

        /// <summary>
        /// Имя 1-ой картинки Технопарка
        /// </summary>
        public string? NameImageTeh_1 { get; set; }

        /// <summary>
        /// Имя 2-ой картинки Технопарка
        /// </summary>
        public string? NameImageTeh_2 { get; set; }

        /// <summary>
        /// Имя 3-ей картинки Технопарка
        /// </summary>
        public string? NameImageTeh_3 { get; set; }

        /// <summary>
        /// Имя 4-ой картинки Технопарка
        /// </summary>
        public string? NameImageTeh_4 { get; set; }

        /// <summary>
        /// Имя 5-ой картинки Технопарка
        /// </summary>
        public string? NameImageTeh_5 { get; set; }
    }
}
