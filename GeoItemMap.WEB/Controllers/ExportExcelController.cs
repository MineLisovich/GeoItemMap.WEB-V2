using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

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

            //создадим заголовки у столбцов и заполнение данными
            worksheet.Cell("A" + 1).Value = "Наименование центра трансфера технологий";
            worksheet.Cell("B" + 1).Value = techTransferCenter.NameTechTransferCenter;

            worksheet.Cell("A" + 2).Value = "Адрес";
            worksheet.Cell("B" + 2).Value = techTransferCenter.AdressTechTransferCenter;

            worksheet.Cell("A" + 3).Value = "Телефон, e-mail, Интернет-сайт";
            worksheet.Cell("B" + 3).Value = techTransferCenter.PhoneTechTransferCenter+"\n"+techTransferCenter.EmailTechTransferCenter+"\n"+techTransferCenter.WebsiteTechTransferCenter;

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

            // Ширина и высота ячеек
            worksheet.Rows(1,12).Height = 100;
            worksheet.Columns(1, 12).Width = 80;
            //перенос текста
            worksheet.Cells().Style.Alignment.WrapText = true;
            //выравнивание текста по вертикали
            worksheet.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //выравнивание текста по горизонтали
            worksheet.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            
            //стили для текста
            worksheet.Cells().Style.Font.FontSize = 13;
            worksheet.Style.Font.SetFontName("Times New Roman");

            //создания сетки в диапазоне
            var rngTable = worksheet.Range("A1:B" + 12);
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
           
            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ЦТТ.xlsx");
            }
        }

        [HttpGet] 
        public IActionResult ExportINN (int id)
        {
            InnProject innProject = InnProjectGenericRepository.FindById(id);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            //создадим заголовки у столбцов и заполнение данными
            worksheet.Cell("A" + 1).Value = "Информация о проекте";
            worksheet.Cell("B" + 1).Value = innProject.NameInnProject;

            worksheet.Cell("A" + 2).Value = "Наименование организации, реализующей проект (мероприятие)";
            worksheet.Cell("B" + 2).Value = innProject.NameOrgImplementingProject;

            worksheet.Cell("A" + 3).Value = "Заказчик";
            worksheet.Cell("B" + 3).Value = innProject.Customer;

            worksheet.Cell("A" + 4).Value = "Сроки реализации";
            worksheet.Cell("B" + 4).Value = innProject.TermsImplementation;

            worksheet.Cell("A" + 5).Value = "ГПИР (2016-2020 гг.; 2021-2025 гг.)";
            worksheet.Cell("B" + 5).Value = innProject.GPIR;

            worksheet.Cell("A" + 6).Value = "Документ, которым проект включен в ГПИР";
            worksheet.Cell("B" + 6).Value = innProject.DocumentByWhichGPIR;

            worksheet.Cell("A" + 7).Value = "Место реализации проекта";
            worksheet.Cell("B" + 7).Value = innProject.LocationProjectImplementation;

            worksheet.Cell("A" + 8).Value = "Статус проекта";
            worksheet.Cell("B" + 8).Value = innProject.ProjectStatus;

            worksheet.Cell("A" + 9).Value = "Инновационность проекта";
            worksheet.Cell("B" + 9).Value = innProject.InnovatProject;

            worksheet.Cell("A" + 10).Value = "Продукция, планируемая к выпуску";
            worksheet.Cell("B" + 10).Value = innProject.ProductsRelease;

            worksheet.Cell("A" + 11).Value = "Вид экономической деятельности";
            worksheet.Cell("B" + 11).Value = innProject.TypeEconomicActivity;

            worksheet.Cell("A" + 12).Value = "Критерий 1 Указа № 357: Организация технологического процесса, обеспечивающего средний уровень добавленной стоимости на одного работающего, аналогичный среднему уровню добавленной стоимости на оного работающего по соответвующему виду экономической деятельности в ЕС, либо превышающий этот уровень, EUR";
            worksheet.Cell("B" + 12).Value = innProject.Criterion1;

            worksheet.Cell("A" + 13).Value = "Критерий №2 Указа № 357: Экспортная ориентированность инновационного проекта (превышение экспорта над импортом), тыс. евро (в год, следующий за годом выхода на проектную мощность)";
            worksheet.Cell("B" + 13).Value = innProject.Criterion2;

            worksheet.Cell("A" + 14).Value = "Критерий №3 Указа № 357: Создание и внедрение новых технологий и (или) производство новой для Республики Беларусь и (или) мировой экономики продукции (мировая новизна; новизна для Республики Беларусь)";
            worksheet.Cell("B" + 14).Value = innProject.Criterion3;

            worksheet.Cell("A" + 15).Value = "Использование технологий V или VI технологических укладов (1 – VI уклад; 2 – V уклад; 3 – проект другого технологического уклада)";
            worksheet.Cell("B" + 15).Value = innProject.UseTechnologies;

            worksheet.Cell("A" + 16).Value = "Годовой объем производства продукции по проекту (год, следующий за годом выхода на проектную мощность), тыс. руб.";
            worksheet.Cell("B" + 16).Value = innProject.AnnualProductionVolumeBY;

            worksheet.Cell("A" + 17).Value = "Годовой объем экспорта по проекту (год, следующий за годом выхода на проектную мощность), тыс. рублей/ тыс. евро";
            worksheet.Cell("B" + 17).Value = innProject.AnnualExportVolumeBY+" / "+ innProject.AnnualExportVolumeEUR;

            worksheet.Cell("A" + 18).Value = "Импортозамещающая направленность проекта (проект направлен на импортозамещение, проект не направлен на импортозамещение)";
            worksheet.Cell("B" + 18).Value = innProject.ImportSubstituting;

            worksheet.Cell("A" + 19).Value = "Добавленная стоимость на одного работника по проекту, тыс. рублей (в год, следующий за годом выхода на проектную мощность)";
            worksheet.Cell("B" + 19).Value = innProject.ValueAddedPerEmployee;

            worksheet.Cell("A" + 20).Value = "Добавленная стоимость по проекту в год, следующий за годом выхода проекта на проектную мощность, тыс. руб.";
            worksheet.Cell("B" + 20).Value = innProject.AddedValueProject;

            worksheet.Cell("A" + 21).Value = "Количество модернизированных рабочих мест, единиц";
            worksheet.Cell("B" + 21).Value = innProject.NumberUpgradedJobs;

            worksheet.Cell("A" + 22).Value = "Количество новых рабочих мест, единиц";
            worksheet.Cell("B" + 22).Value = innProject.NumberNewJobs;

            worksheet.Cell("A" + 23).Value = "Объем финансирования проекта, тыс. рублей";
            worksheet.Cell("B" + 23).Value = innProject.VolumeFinancing;


            // Ширина и высота ячеек
            worksheet.Rows(1, 23).Height = 100;
            worksheet.Columns(1, 23).Width = 80;
            //перенос текста
            worksheet.Cells().Style.Alignment.WrapText = true;
            //выравнивание текста по вертикали
            worksheet.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //выравнивание текста по горизонтали
            worksheet.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            //стили для текста
            worksheet.Cells().Style.Font.FontSize = 13;
            worksheet.Style.Font.SetFontName("Times New Roman");

            //создания сетки в диапазоне
            var rngTable = worksheet.Range("A1:B" + 23);
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ИНН.xlsx");
            }
        }

        [HttpGet]
        public IActionResult ExportNTP (int id)
        {
            NtpProject ntpProject = NtpProjectGenericRepository.FindById(id);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            //создадим заголовки у столбцов и заполнение данными
            worksheet.Cell("A" + 1).Value = "Название программы (подпрограммы), наименование и номер документа, которым утверждена программа";
            worksheet.Cell("B" + 1).Value = ntpProject.NameProgramm;

            worksheet.Cell("A" + 2).Value = "Государственный заказчик (ответственный заказчик)";
            worksheet.Cell("B" + 2).Value = ntpProject.StateCustomer;

            worksheet.Cell("A" + 3).Value = "Головная организация-исполнитель";
            worksheet.Cell("B" + 3).Value = ntpProject.ParentImplemOrg;

            worksheet.Cell("A" + 4).Value = "Наименование выполняемого задания";
            worksheet.Cell("B" + 4).Value = ntpProject.NameTask;

            worksheet.Cell("A" + 5).Value = "Организации - исполнители НИОК(Т)Р";
            worksheet.Cell("B" + 5).Value = ntpProject.ImplemOrg;

            worksheet.Cell("A" + 6).Value = "Адрес организации-исполнителя";
            worksheet.Cell("B" + 6).Value = ntpProject.AdressImplemOrg;

            worksheet.Cell("A" + 7).Value = "Информация о стадии выполнения задания программы";
            worksheet.Cell("B" + 7).Value = ntpProject.StateTask;

            worksheet.Cell("A" + 8).Value = "Уровень технологического уклада разработки по заданию (IV, V, VI технологический уклад).";
            worksheet.Cell("B" + 8).Value = ntpProject.TheLevelStructure;

            worksheet.Cell("A" + 9).Value = "Наименование вновь освоенной продукции (инновации)";
            worksheet.Cell("B" + 9).Value = ntpProject.NameNewDevProducts;

            worksheet.Cell("A" + 10).Value = "Информация о наличии экспорта по заданию (имеется или не имеется).";
            worksheet.Cell("B" + 10).Value = ntpProject.InformationExports;

            worksheet.Cell("A" + 11).Value = "Информация о создании новых производств, модернизации   действующих производств (указать организацию, где проводились работы, какие новшества планируется внедрять в результате проведенных работ)";
            worksheet.Cell("B" + 11).Value = ntpProject.InformationNewProduct;

          

            // Ширина и высота ячеек
            worksheet.Rows(1, 11).Height = 100;
            worksheet.Columns(1, 11).Width = 80;
            //перенос текста
            worksheet.Cells().Style.Alignment.WrapText = true;
            //выравнивание текста по вертикали
            worksheet.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //выравнивание текста по горизонтали
            worksheet.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            //стили для текста
            worksheet.Cells().Style.Font.FontSize = 13;
            worksheet.Style.Font.SetFontName("Times New Roman");

            //создания сетки в диапазоне
            var rngTable = worksheet.Range("A1:B" + 11);
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "НТП.xlsx");
            }
        }

        [HttpGet]
        public IActionResult ExportTechnoParck(int id)
        {
            Technopark technopark = TechnoparkGenericRepository.FindById(id);

            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            //создадим заголовки у столбцов и заполнение данными
            worksheet.Cell("A" + 1).Value = "Наименование технопарка";
            worksheet.Cell("B" + 1).Value = technopark.NameTechnopark;

            worksheet.Cell("A" + 2).Value = "Контактные данные (адрес, телефон, e-mail, Интернет-сайт)";
            worksheet.Cell("B" + 2).Value = technopark.AddressTechnopark+"\n"+technopark.PhoneTechnopark+"\n"+technopark.EmailTechnopark+"\n"+technopark.WebsiteTechnopark;

            worksheet.Cell("A" + 3).Value = "Общая площадь помещений (м^2)";
            worksheet.Cell("B" + 3).Value = technopark.TotalAreaPremises;

            worksheet.Cell("A" + 4).Value = "Свободная площадь помещений (м^2)";
            worksheet.Cell("B" + 4).Value = technopark.FreeAreaPremises;

            worksheet.Cell("A" + 5).Value = "Специализация технопарка";
            worksheet.Cell("B" + 5).Value = technopark.TechSpecialization;

            worksheet.Cell("A" + 6).Value = "Ключевые виды продукции резидентов технопарка";
            worksheet.Cell("B" + 6).Value = technopark.TypesProducts;

            worksheet.Cell("A" + 7).Value = "Услуги, предоставляемые технопарком резиденту (сдача в аренду готовых помещений, телефонная связь, бухгалтерские услуги и т.д.)";
            worksheet.Cell("B" + 7).Value = technopark.ServicesProvided;

            worksheet.Cell("A" + 8).Value = "Технологическая инфраструктура технопарка, технологическое оборудование (бизнес-инкубатор, центр коллективного пользования оборудованием, коворкинг-центр, лаборатория и т.д.)";
            worksheet.Cell("B" + 8).Value = technopark.TechInfrastructure;

            worksheet.Cell("A" + 9).Value = "Общее количество резидентов технопарка, ед. (по итогам 2022 г.)";
            worksheet.Cell("B" + 9).Value = technopark.TotalNumberResident;

            worksheet.Cell("A" + 10).Value = "Количество работников резидентов технопарка на конец отчетного периода, ед. (по итогам 2022 г.)";
            worksheet.Cell("B" + 10).Value = technopark.NumberEmployees;

            worksheet.Cell("A" + 11).Value = "Объем отгруженной (выполненной) резидентами технопарка продукции (работ, услуг) за 2022 г. (в тыс. бел.рублей)";
            worksheet.Cell("B" + 11).Value = technopark.VolComplProducts;

            worksheet.Cell("A" + 12).Value = "Объем финансирования в рамках ГПИР 2021-2025 (в тыс. бел.рублей)";
            worksheet.Cell("B" + 12).Value = technopark.AmountFunding;

            // Ширина и высота ячеек
            worksheet.Rows(1, 12).Height = 100;
            worksheet.Columns(1, 12).Width = 80;
            //перенос текста
            worksheet.Cells().Style.Alignment.WrapText = true;
            //выравнивание текста по вертикали
            worksheet.Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
            //выравнивание текста по горизонтали
            worksheet.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            //стили для текста
            worksheet.Cells().Style.Font.FontSize = 13;
            worksheet.Style.Font.SetFontName("Times New Roman");

            //создания сетки в диапазоне
            var rngTable = worksheet.Range("A1:B" + 12);
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Технопарк.xlsx");
            }
        }
    }
}
