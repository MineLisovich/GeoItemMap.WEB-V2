using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities
{
    public class InnProject : GeoItem
    {
        /// <summary>
        /// Информация о проекте 
        /// </summary>
        [Required]
       // [StringLength(250)]
        public string? NameInnProject { get; set; }

        /// <summary>
        /// Наименование организации, реализующей проект (мероприятие)
        /// </summary>
        [Required]
     //   [StringLength(250)]
        public string? NameOrgImplementingProject { get; set; }

        /// <summary>
        /// Заказчик
        /// </summary>
        [Required]
       // [StringLength(250)]
        public string? Customer { get; set;}


        /// <summary>
        /// Сроки реализации
        /// </summary>
        [Required]
       // [StringLength(20)]
        public string? TermsImplementation { get; set;}

        /// <summary>
        /// ГПИР
        /// </summary>
        [Required]
       // [StringLength(30)]
        public string? GPIR { get; set; }

        /// <summary>
        /// Документ, которым проект включен в ГПИР
        /// </summary>
        [Required]
       // [StringLength (30)]
        public string? DocumentByWhichGPIR { get; set;}

        /// <summary>
        /// Место реализации проекта
        /// </summary>
        [Required]
      //  [StringLength(100)]
        public string? LocationProjectImplementation { get; set;}

        /// <summary>
        /// Статус проекта
        /// </summary>
        [Required]
      //  [StringLength(30)]
        public string? ProjectStatus { get; set;}

        /// <summary>
        /// Инновационность проекта
        /// </summary>
        [Required]
       // [StringLength(1000)]
        public string? InnovatProject { get; set;}

        /// <summary>
        /// Продукция, планируемая к выпуску
        /// </summary>
        [Required]
      //  [StringLength(500)]
        public string? ProductsRelease { get; set;}

        /// <summary>
        /// Вид экономической деятельности 
        /// </summary>
        [Required]
      //  [StringLength(250)]
        public string? TypeEconomicActivity { get; set;}

        /// <summary>
        /// Критерий 1 Указа № 357: Организация технологического процесса, обеспечивающего средний уровень добавленной стоимости на одного работающего, аналогичный среднему уровню добавленной стоимости на оного работающего по соответвующему виду экономической деятельности в ЕС, либо превышающий этот уровень, EUR
        /// </summary>
        [Required]
        [Precision(10,2)]
        public decimal? Criterion1 { get; set;}


        /// <summary>
        /// Критерий 2 Указа № 357: Экспортная ориентированность инновационного проекта (превышение экспорта над импортом), тыс. евро (в год, следующий за годом выхода на проектную мощность)
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? Criterion2 { get; set; }

        /// <summary>
        /// Критерий 3 Указа № 357: Создание и внедрение новых технологий и (или) производство новой для Республики Беларусь и (или) мировой экономики продукции (true (1) – мировая новизна; false (0) – новизна для Республики Беларусь)
        /// </summary>
        [Required]
        public bool? Criterion3 { get; set; }


        /// <summary>
        /// Использование технологий V или VI технологических укладов   (1 – VI уклад; 2 – V уклад; 3 – проект другого технологического уклада)
        /// </summary>
        [Required]
       // [StringLength(10)]
        public string? UseTechnologies { get; set;}

        /// <summary>
        /// Годовой объем производства продукции по проекту (год, следующий за годом выхода на проектную мощность), тыс. руб.
        /// </summary>
        [Required]
        [Precision(10,2)]
        public decimal? AnnualProductionVolumeBY { get; set; }

        /// <summary>
        /// Годовой объем экспорта по проекту  тыс. рублей
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? AnnualExportVolumeBY { get; set;}

        /// <summary>
        /// Годовой объем экспорта по проекту  тыс. евро
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? AnnualExportVolumeEUR { get; set; }


        /// <summary>
        /// Импортозамещающая направленность проекта (1 - проект направлен на импортозамещение, 0 - проект не направлен на импортозамещение)
        /// </summary>
        [Required]
        public bool? ImportSubstituting { get; set; }


        /// <summary>
        /// Добавленная стоимость на одного работника по проекту, тыс. рублей (в год, следующий за годом выхода на проектную мощность)
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? ValueAddedPerEmployee { get; set; }


        /// <summary>
        ///Добавленная стоимость по проекту в год, следующий за годом выхода проекта на проектную мощность, тыс. руб.
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? AddedValueProject { get; set; }

        /// <summary>
        /// Количество модернизированных рабочих мест, единиц
        /// </summary>
        [Required]
        public short? NumberUpgradedJobs { get; set; }

        /// <summary>
        /// Количество новых рабочих мест, единиц
        /// </summary>
        [Required]
        public short? NumberNewJobs { get; set; }

        /// <summary>
        /// Объем финансирования проекта, тыс. рублей
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? VolumeFinancing { get; set; }

    }
}
