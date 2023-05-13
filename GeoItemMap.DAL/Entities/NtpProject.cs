using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities
{
    public class NtpProject : GeoItem 
    {
        /// <summary>
        /// Название программы (подпрограммы), наименование и номер документа, которым утверждена программа, пример: БПТ_14
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? NameProgramm { get; set; }

        /// <summary>
        /// Государственный заказчик (ответственный заказчик)
        /// </summary>
        [Required]
       // [StringLength(250)]
        public string? StateCustomer { get; set; }


        /// <summary>
        /// Головная организация-исполнитель
        /// </summary>
        [Required]
       // [StringLength (50)]
        public string? ParentImplemOrg { get; set;}

        /// <summary>
        /// организация-исполнитель
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? ImplemOrg { get; set; }
        /// <summary>
        /// Страна организации-исполнителя
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? CountryImplemOrg { get; set; }

        /// <summary>
        /// Область организации-исполнителя
        /// </summary>
        [Required]
       /// [StringLength(50)]
        public string? AreaImplemOrg { get; set; }

        /// <summary>
        /// Город организации-исполнителя
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? CityImplemOrg { get; set; }


        /// <summary>
        /// Наименование выполняемого задания
        /// </summary>
        [Required]
       // [StringLength(250)]
        public string? NameTask { get; set; }

        /// <summary>
        /// Информация о стадии выполнения задания программы 
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? StateTask { get; set;}


        /// <summary>
        /// Уровень технологического уклада разработки по заданию (IV, V, VI технологический уклад).
        /// </summary>
        [Required]
      //  [StringLength(50)]
        public string? Thelevelstructure { get; set;}

        /// <summary>
        /// Наименование вновь освоенной продукции (инновации)
        /// </summary>
        [Required]
      //  [StringLength(50)]
        public string? NameNewDevProducts { get; set;}


        /// <summary>
        /// Информация о наличии экспорта по заданию (имеется или не имеется). 
        /// </summary>
        [Required]
       // [StringLength(20)]
        public string? InformationExports  { get; set; }

        /// <summary>
        /// Информация о создании новых производств, модернизации   действующих производств (указать организацию, где проводились работы, какие новшества планируется внедрять в результате проведенных работ) 
        /// </summary>
        [Required]
      //  [StringLength(1000)]
        public string? InformationNewProduct { get; set;}
      

    }
}
