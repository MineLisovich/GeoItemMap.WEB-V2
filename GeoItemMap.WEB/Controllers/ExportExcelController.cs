using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using ClosedXML.Excel;

namespace GeoItemMap.WEB.Controllers
{
    public class ExportExcelController : Controller
    {
        private IGenericRepository<GeoItem> GeoItemGenericRepository;
        private IGenericRepository<InnProject> InnProjectGenericRepository;
        private IGenericRepository<NtpProject> NtpProjectGenericRepository;
        private IGenericRepository<Technopark> TechnoparkGenericRepository;
        private IGenericRepository<TechTransferCenter> TechTransferCenterGenericRepository;
        public ExportExcelController(
           IGenericRepository<GeoItem> _GeoItemGenericRepository,
           IGenericRepository<InnProject> _InnProjectGenericRepository,
           IGenericRepository<NtpProject> _NtpProjectGenericRepository,
           IGenericRepository<Technopark> _TechnoparkGenericRepository,
           IGenericRepository<TechTransferCenter> _TechTransferCenterGenericRepository)
        {
           
            GeoItemGenericRepository = _GeoItemGenericRepository;
            InnProjectGenericRepository = _InnProjectGenericRepository;
            NtpProjectGenericRepository = _NtpProjectGenericRepository;
            TechnoparkGenericRepository = _TechnoparkGenericRepository;
            TechTransferCenterGenericRepository = _TechTransferCenterGenericRepository;
        }

        [HttpGet]
        public  IActionResult ExportCTT (int id)
        {     
            TechTransferCenter techTransferCenter = TechTransferCenterGenericRepository.FindById(id);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            //создадим заголовки у столбцов
            worksheet.Cell("A" + 1).Value = "Наименование центра трансфера технологий";
            worksheet.Cell("B" + 1).Value = techTransferCenter.NameTechTransferCenter;

            worksheet.Cell("A" + 2).Value = "Адрес";
            worksheet.Cell("B" + 2).Value = techTransferCenter.AdressTechTransferCenter;

            worksheet.Cell("A" + 3).Value = "Телефон, e-mail, Интернет-сайт";
            worksheet.Cell("B" + 3).Value = techTransferCenter.PhoneTechTransferCenter+" "+techTransferCenter.EmailTechTransferCenter+" "+techTransferCenter.WebsiteTechTransferCenter;

            worksheet.Cell("A" + 4).Value = "Услуги, предоставляемые центром трансфера технологий";
            worksheet.Cell("B" + 4).Value = techTransferCenter.ServicesProvidedTechTransferCenter;

            worksheet.Cell("A" + 5).Value = "Количество поступивших в центр и принятых к работе технологических предложений в 2022 году (ед.)";
            worksheet.Cell("B" + 5).Value = techTransferCenter.NumberAcceptedWorkProposals;

            worksheet.Cell("A" + 6).Value = "Количество поступивших в центр и принятых к работе технологических запросов в 2022 году (ед.)";
            worksheet.Cell("B" + 6).Value = techTransferCenter.NumberAcceptedWorkRequests;

            worksheet.Cell("A" + 7).Value = "Количество заключенных при содействии центра сделок по передаче (приобретению) прав на результаты научно-технической и (или) инновационной деятельности за 2022 год (ед.)";
            worksheet.Cell("B" + 7).Value = techTransferCenter.NumberTransactionsConcluded;

            worksheet.Cell("A" + 8).Value = "Объем заключенных при содействии центра сделок по передаче (приобретению) прав на результаты научно-технической и (или) инновационной деятельности за  2022 год (тыс. рублей)";
            worksheet.Cell("B" + 8).Value = techTransferCenter.VolumeTransactionsConcluded;

            worksheet.Cell("A" + 9).Value = "Количество сформированных при содействии центра научно-технических, инновационных (инвестиционных) и иных проектов (работ) за  2022 год (ед.)";
            worksheet.Cell("B" + 9).Value = techTransferCenter.NumberGeneratedProjects;

            worksheet.Cell("A" + 10).Value = "Объем сформированных при содействии центра научно-технических, инновационных (инвестиционных) и иных проектов (работ) за 2022 год (тыс. рублей)";
            worksheet.Cell("B" + 10).Value = techTransferCenter.VolumeGeneratedProjects;

            worksheet.Cell("A" + 11).Value = "Объем выполненных центром работ (услуг), связанных с коммерциализацией результатов научно-технической и (или) инновационной деятельности за 2022 год (тыс. рублей)";
            worksheet.Cell("B" + 11).Value = techTransferCenter.VolumeWorkPerformed;

            worksheet.Cell("A" + 12).Value = "Объем финансирования в рамках ГПИР 2021-2025 (в тыс. бел.рублей)";
            worksheet.Cell("B" + 12).Value = techTransferCenter.AmountFunding;





            //пример изменения стиля ячейки
            //worksheet.Cell("B" + 2).Style.Fill.BackgroundColor = XLColor.Red;

            // пример создания сетки в диапазоне
            var rngTable = worksheet.Range("A1:B" + 12);
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            worksheet.Columns().AdjustToContents(); //ширина столбца по содержимому

            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Base.xlsx");
            }
        }
    }
}
