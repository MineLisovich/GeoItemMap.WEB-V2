using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Entities
{
    public class TechTransferCenter : GeoItem
    {
        /// <summary>
        /// Наименование центра трансфера технологий
        /// </summary>
        [Required]
    //    [StringLength(250)]  
        public string? NameTechTransferCenter { get; set; }

        /// <summary>
        /// Адресс центра трансфера технологий
        /// </summary>
        [Required]
      //  [StringLength(100)]
        public string? AdressTechTransferCenter { get; set; }

        /// <summary>
        /// Телефон центра трансфера технологий
        /// </summary>
        [Required]
       // [StringLength(50)]
        public string? PhoneTechTransferCenter { get; set; }

        /// <summary>
        /// Электронная почта центра трансфера технологий
        /// </summary>
        [Required]
      //  [StringLength(50)]
        public string? EmailTechTransferCenter { get; set; }

        /// <summary>
        /// Веб-сайт  центра трансфера технологий
        /// </summary>
        [Required]
       /// [StringLength(50)]
        public string? WebsiteTechTransferCenter { get; set; }

        /// <summary>
        /// Услуги, предоставляемые центром трансфера технологий
        /// </summary>
        [Required]
      //  [StringLength(250)]
        public string? ServicesProvidedTechTransferCenter { get; set; }

        /// <summary>
        /// Количество поступивших в центр и принятых к работе технологических предложений
        /// </summary>
        [Required]
        public short? NumberAcceptedWorkProposals { get; set; }

        /// <summary>
        /// Количество поступивших в центр и принятых к работе технологических запросов в 2022 году
        /// </summary>
        [Required]
        public short? NumberAcceptedWorkRequests { get; set; }

        /// <summary>
        /// Количество заключенных при содействии центра сделок по передаче (приобретению) прав на результаты научно-технической и (или) инновационной деятельности
        /// </summary>
        [Required]
        public short? NumberTransactionsConcluded { get; set; }

        /// <summary>
        /// Объем заключенных при содействии центра сделок по передаче (приобретению) прав на результаты научно-технической и (или) инновационной деятельности 
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? VolumeTransactionsConcluded { get; set; }

        /// <summary>
        /// Количество сформированных при содействии центра научно-технических, инновационных (инвестиционных) и иных проектов (работ)
        /// </summary>
        [Required]
        public short? NumberGeneratedProjects { get; set; }


        /// <summary>
        /// Объем сформированных при содействии центра научно-технических, инновационных (инвестиционных) и иных проектов (работ)
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? VolumeGeneratedProjects { get; set; }

        /// <summary>
        /// Объем выполненных центром работ (услуг), связанных с коммерциализацией результатов научно-технической и (или) инновационной деятельности 
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? VolumeWorkPerformed { get; set; }

        /// <summary>
        ///  Объем финансирования 
        /// </summary>
        [Required]
        [Precision(10, 2)]
        public decimal? AmountFunding { get; set; } 

    }
}
