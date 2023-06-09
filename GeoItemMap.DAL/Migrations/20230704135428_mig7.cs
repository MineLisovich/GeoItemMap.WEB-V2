﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoItemMap.DAL.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<float>(type: "real", nullable: false),
                    Y = table.Column<float>(type: "real", nullable: false),
                    GeoType = table.Column<int>(type: "int", nullable: false),
                    Region = table.Column<int>(type: "int", nullable: false),
                    statusInn = table.Column<short>(type: "smallint", nullable: false),
                    statusNtp = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InnProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameInnProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOrgImplementingProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TermsImplementation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPIR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentByWhichGPIR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationProjectImplementation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InnovatProject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductsRelease = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeEconomicActivity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Criterion1 = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Criterion2 = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Criterion3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UseTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnualProductionVolumeBY = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AnnualExportVolumeBY = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AnnualExportVolumeEUR = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    ImportSubstituting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueAddedPerEmployee = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AddedValueProject = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NumberUpgradedJobs = table.Column<short>(type: "smallint", nullable: false),
                    NumberNewJobs = table.Column<short>(type: "smallint", nullable: false),
                    VolumeFinancing = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NameImageInn_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageInn_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageInn_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageInn_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageInn_5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InnProjects_GeoItems_Id",
                        column: x => x.Id,
                        principalTable: "GeoItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NtpProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameProgramm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdressImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TheLevelStructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameNewDevProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationExports = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationNewProduct = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameImageNtp_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageNtp_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageNtp_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageNtp_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageNtp_5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NtpProject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NtpProject_GeoItems_Id",
                        column: x => x.Id,
                        principalTable: "GeoItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Technoparks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameTechnopark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressTechnopark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneTechnopark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTechnopark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteTechnopark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAreaPremises = table.Column<float>(type: "real", nullable: false),
                    FreeAreaPremises = table.Column<float>(type: "real", nullable: false),
                    TechSpecialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypesProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesProvided = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechInfrastructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalNumberResident = table.Column<short>(type: "smallint", nullable: true),
                    NumberEmployees = table.Column<short>(type: "smallint", nullable: false),
                    VolComplProducts = table.Column<float>(type: "real", nullable: false),
                    AmountFunding = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NameImageTeh_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageTeh_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageTeh_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageTeh_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageTeh_5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technoparks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technoparks_GeoItems_Id",
                        column: x => x.Id,
                        principalTable: "GeoItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TechTransferCenters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdressTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesProvidedTechTransferCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberAcceptedWorkProposals = table.Column<short>(type: "smallint", nullable: false),
                    NumberAcceptedWorkRequests = table.Column<short>(type: "smallint", nullable: false),
                    NumberTransactionsConcluded = table.Column<short>(type: "smallint", nullable: false),
                    VolumeTransactionsConcluded = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    NumberGeneratedProjects = table.Column<short>(type: "smallint", nullable: false),
                    VolumeGeneratedProjects = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    VolumeWorkPerformed = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AmountFunding = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NameImageCtt_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageCtt_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageCtt_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageCtt_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameImageCtt_5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechTransferCenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechTransferCenters_GeoItems_Id",
                        column: x => x.Id,
                        principalTable: "GeoItems",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "GeoItems",
                columns: new[] { "Id", "GeoType", "Region", "X", "Y", "statusInn", "statusNtp" },
                values: new object[,]
                {
                    { 201, 2, 7, 53.917225f, 27.549812f, (short)2, (short)0 },
                    { 202, 2, 7, 53.90289f, 27.51202f, (short)2, (short)0 },
                    { 203, 2, 5, 54.189735f, 28.49261f, (short)2, (short)0 },
                    { 1001, 3, 7, 53.9387f, 27.602226f, (short)0, (short)2 },
                    { 1002, 3, 2, 55.167625f, 30.239363f, (short)0, (short)2 },
                    { 1, 1, 4, 53.684956f, 23.839453f, (short)0, (short)0 },
                    { 2, 1, 5, 53.88728f, 26.967253f, (short)0, (short)0 },
                    { 3, 1, 1, 53.12245f, 26.041328f, (short)0, (short)0 },
                    { 4, 1, 2, 55.19271f, 30.21926f, (short)0, (short)0 },
                    { 5, 1, 3, 52.42506f, 31.01014f, (short)0, (short)0 },
                    { 6, 1, 4, 53.89851f, 25.297256f, (short)0, (short)0 },
                    { 101, 0, 7, 53.925674f, 27.59164f, (short)0, (short)0 },
                    { 102, 0, 2, 55.530853f, 28.647306f, (short)0, (short)0 },
                    { 103, 0, 2, 55.178352f, 30.23797f, (short)0, (short)0 },
                    { 104, 0, 1, 52.113556f, 26.112936f, (short)0, (short)0 },
                    { 105, 0, 7, 53.84014f, 27.47747f, (short)0, (short)0 },
                    { 106, 0, 4, 53.711216f, 23.826435f, (short)0, (short)0 },
                    { 107, 0, 6, 54.290287f, 30.987661f, (short)0, (short)0 },
                    { 108, 0, 1, 52.097225f, 23.731108f, (short)0, (short)0 },
                    { 109, 0, 2, 55.15899f, 30.235449f, (short)0, (short)0 },
                    { 110, 0, 3, 52.47443f, 30.99671f, (short)0, (short)0 },
                    { 111, 0, 3, 52.479782f, 30.989746f, (short)0, (short)0 },
                    { 112, 0, 5, 53.979046f, 28.027534f, (short)0, (short)0 },
                    { 113, 0, 6, 53.144405f, 29.21945f, (short)0, (short)0 },
                    { 114, 0, 5, 53.834774f, 28.011541f, (short)0, (short)0 },
                    { 115, 0, 6, 53.148197f, 29.214527f, (short)0, (short)0 },
                    { 116, 0, 6, 53.904915f, 30.343761f, (short)0, (short)0 },
                    { 117, 0, 7, 53.90276f, 27.644878f, (short)0, (short)0 },
                    { 118, 0, 7, 53.875854f, 27.655737f, (short)0, (short)0 },
                    { 119, 0, 7, 53.88313f, 27.592127f, (short)0, (short)0 },
                    { 120, 0, 7, 53.901115f, 27.497475f, (short)0, (short)0 },
                    { 121, 0, 7, 53.89705f, 27.599731f, (short)0, (short)0 }
                });

            migrationBuilder.InsertData(
                table: "InnProjects",
                columns: new[] { "Id", "AddedValueProject", "AnnualExportVolumeBY", "AnnualExportVolumeEUR", "AnnualProductionVolumeBY", "Criterion1", "Criterion2", "Criterion3", "Customer", "DocumentByWhichGPIR", "GPIR", "ImportSubstituting", "InnovatProject", "LocationProjectImplementation", "NameImageInn_1", "NameImageInn_2", "NameImageInn_3", "NameImageInn_4", "NameImageInn_5", "NameInnProject", "NameOrgImplementingProject", "NumberNewJobs", "NumberUpgradedJobs", "ProductsRelease", "ProjectStatus", "TermsImplementation", "TypeEconomicActivity", "UseTechnologies", "ValueAddedPerEmployee", "VolumeFinancing" },
                values: new object[,]
                {
                    { 201, 16778.1m, 10371.1m, 4203.1m, 17704.7m, 74359.9m, 5700.0m, "Новизна для Республики Беларусь", "Министерство здравоохранения Республики Беларусь", "Постановление СМ от 12.11.2021 № 642", "ГПИР 2021-2025", "Проект не направлен на импортозамещение", "Инновационность заключается в самообеспечении Республики Беларусь инновационной биотехнологической продукцией, высококачественными и безопасными отечественными лекарственными средствами из плазмы крови, генноинженерными фармсубстанциями, биомедицинским клеточным продуктом по доступным ценам, для снижения зависимости Республики Беларусь от импорта медицинских препаратов, организация экспортных поставок. Проект имеет большую социально-экономическую значимость, экспортную направленность, инновационность, высокий уровень внедряемых технологий. Создание современного биофармацевтического производства позволит: располагать собственными стратегическими для безопасности республики технологиями производства и контроля качества биотехнологических продуктов; реализовать принцип независимости государства от колебаний мирового рынка плазмы и лекарственных средств из плазмы крови; обеспечить дополнительные рабочие места; ежегодно экономить бюджетные ассигнования, при существующем объеме заготовки плазмы за счет отказа от покупки импортных лекарственных средств из плазмы крови и рекомбинантных белков; обеспечить высокую социально-экономическую эффективность и заложить экспортный потенциал ввиду высокого уровня добавленной стоимости на одного работника нового производства и наличия уникальных отечественных биофармацевтических технологий; обеспечить экспорт биотехнологической продукции.", "г. Минск / «Великий камень», г. Ганцевичи, Брестская обл.", null, null, null, null, null, "Организация биофармацевтического производства лекарственных средств на основе рекомбинантных технологий и фракционирования плазмы крови, соответствующего требованиям GMP", "Государственное учреждение «Республиканский научно-практический центр трансфузиологии и медицинских биотехнологий»", (short)20, (short)70, "Планируются к производству новые иинновационные лекарственные средства: иммуноглобулин человека для внутривенного введения (иммунологический препарат, обладает антибактериальными, противовирусными свойствами, неспецифической иммунорегуляторной активностью); концентрат факторов протромбинового комплекса (ППСБ) (гемостатическое средство для внутривенного введения, используется для профилактики кровотечений при приобретенном дефиците факторов протромбинового комплекса и врожденном дефиците одного из витамин К-зависимых факторов свертывания); Плазмабел (вирусинактивированная криоплазма), Нормоплаз (сухая плазма, патогенредуцированная е пролонгированным сроком хранения); Концентрат фактора VIII (антигемофильное лекарственное средство для терапии и профилактика кровотечений у пациентов с врожденньш (гемофилия А) и приобретенным дефицитом фактора). Инновационный проект предусматривает организацию промышленного производства рекомбинантных фармсубстанций по разработанным технологиям: фармацевтическая субстанция человеческого рекомбинантного интерферона альфа 2Ь, продуцируется генетически измененным штаммом бактерии EscherichiacoHBL21 (DE3)/pET - интерферон альфа 2Ь, обладает неспецифнчеекой противовирусной и антапролиферативной активностью, оказывает угнетающее влияние на синтез некоторых онкогенов, приводящее к ингибированию опухолевого роста; фармацевтическая субстанция человеческого рекомбинантного гранулоцитарного колониестимулирующего фактора (филграстим), продуцируется генетически измененным штаммом бактерии EscherichiacoKBL21 (DE3)/pET-r-КСФ, в геном которой методами генной инженерии введен ген гранулоцитарного колониестимулирующего фактора человека. Стимулятор лейкопоэза, регулирующий образование функционально активных нейтрофилов и их выход в кровь из костного мозга, значительно уменьшает частоту тяжесть и продолжительность нейтропении при химиотерапии цитостатикамии др.Также запланировано производство новых инновационных изделий медицинского назначения: клей хирургический двухкомпонентный на основе альбумина для герметизации и укрепления хирургических швов, склеивания тканей; плазма обогащенная ростовыми факторами тромбоцитов. Планируется производство биомедицинского клеточного продукта.", "В стадии реализации", "2021-2024 гг.", "Секция Q* Здравоохранение и социальные услуги Подсекция QA: Здравоохранение Код раздела 86: Здравоохранение", "1;2", 186.4m, 90233.4m },
                    { 202, 8832.4m, 10117.8m, 0m, 46396.1m, 184659.0m, 3063.5m, "Новизна для Республики Беларусь", "Национальная академия наук Беларуси", "Постановление СМ от 12.11.2021 № 642", "ГПИР 2021-2025", "Проект не направлен на импортозамещение", "Инновационная направленность реализации проекта «Создание опытно-промышленного производства твердых лекарственных форм с применением инновационных технологий» заключается в инновационности применяемых технологических решений.В части локализации производства на территории Республики Беларусь эффективных и безопасных лекарственных средств для лечения социально-значимых заболеваний: ВИЧ-инфекции, гепатита В, болезни Альцгеймера, подагры, эпилепсии, ревматоидного артрита, тромбоэмболии и др. Актуальной тенденцией в области рассматриваемой проблемы является использование экструзии горячих расплавов. Эта технология является инновационной для фармацевтической промышленности, о чем свидетельствуют последние разработки зарубежных ученых.", "г. Минск", null, null, null, null, null, "Создание опытно-промышленного производства твердых лекарственных форм с применением инновационных технологий", "Республиканское производственное унитарное предприятие «АКАДЕМФАРМ»", (short)21, (short)0, "Производство широкого ассортимента лекарственных средств, в частности: антиретровирусные препараты; препаратов для лечения нервной системы, болезни Альцгеймера; Препаратов для лечения вирусных гепатитов; препаратов для лечения костно-мышечных заболеваний; препаратов для лечения бронхиальной астмы; антикоагулянта", "В стадии реализации", "2020-2025 гг.", "С21201( производство основных фармацевтических продуктов и прапаратов)", "2", 784.3m, 7835.0m },
                    { 203, 49728.9m, 103870.9m, 0m, 136492.7m, 79.7m, 58479.8m, "Новизна для Республики Беларусь", "Министерство промышленности Республики Беларусь", "Постановление СМ от 20.12.2017 № 977", "ГПИР (2016-2020 гг.; 2021-2025 гг.)", "Проект не направлен на импортозамещение", "По результатам реализации проекта предполагается к выпуску новая и модернизированная продукция, а также предусматривается замещение жёстких производственных линий на гибкие быстро переналаживаемые линии по производству рулевых систем для автомобилей, оптимизацию использования производственных площадей путем размещения производств на одной производственной площадке. Эти изделия относятся к наукоемкой, высокотехнологичной, импортозамещающей продукции и используется в производстве автомобилей и автобусов. Изделия будут иметь технические характеристики на уровне мировых аналогов и конкурентную цену, а отсутствие аналогов в Республике Беларусь, позволит заместить импортные поставки, а также расширить рынок поставок рулевых систем в страны ближнего и дальнего зарубежья.", "Минская обл., г.Борисов, ул.Чапаева, 56.", null, null, null, null, null, "«Создание современного гибкого автоматизированного производства узлов рулевого управления для комплектации автомобильной техники»", "Открытое Акционерное Общество «Борисовский завод «Автогидроусилитель»", (short)43, (short)0, "Механизмы рулевого управления,насосы общепромышленного применения,гидравлические системы, гидроцилиндры", "В стадии реализации", "2017-2023 гг.", "Секция С «Обрабатывающая промышленность№ ; Подсекция CL» производство транспортных средств и оборудования» раздел 29", "3", 181.5m, 56652.5m }
                });

            migrationBuilder.InsertData(
                table: "NtpProject",
                columns: new[] { "Id", "AdressImplemOrg", "ImplemOrg", "InformationExports", "InformationNewProduct", "NameImageNtp_1", "NameImageNtp_2", "NameImageNtp_3", "NameImageNtp_4", "NameImageNtp_5", "NameNewDevProducts", "NameProgramm", "NameTask", "ParentImplemOrg", "StateCustomer", "StateTask", "TheLevelStructure" },
                values: new object[,]
                {
                    { 1001, "Республика Беларусь,Минская область, г. Минск ", "ОАО «МНИПИ»", "", "", null, null, null, null, null, "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.", "РО3.15", "«Разработать и освоить производство подвижного информационного комплекса», шифр «Контент»", "ОАО «МНИПИ»", "", "", "V технологический уклад" },
                    { 1002, "Республика Беларусь,Витебская область, г. Витебск", "ОАО «Витязь»", "", "", null, null, null, null, null, "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.", "БПТ_14", "«Разработать и освоить в серийном производстве стационарную электрозарядную станцию постоянного тока для легковых электромобилей»", "ОАО «Витязь»", "", "", "V технологический уклад" }
                });

            migrationBuilder.InsertData(
                table: "TechTransferCenters",
                columns: new[] { "Id", "AdressTechTransferCenter", "AmountFunding", "EmailTechTransferCenter", "NameImageCtt_1", "NameImageCtt_2", "NameImageCtt_3", "NameImageCtt_4", "NameImageCtt_5", "NameTechTransferCenter", "NumberAcceptedWorkProposals", "NumberAcceptedWorkRequests", "NumberGeneratedProjects", "NumberTransactionsConcluded", "PhoneTechTransferCenter", "ServicesProvidedTechTransferCenter", "VolumeGeneratedProjects", "VolumeTransactionsConcluded", "VolumeWorkPerformed", "WebsiteTechTransferCenter" },
                values: new object[,]
                {
                    { 1, "230023, г. Гродно, ул. Ожешко,22", 364m, "ctt@grsu.by", null, null, null, null, null, "УО «Гродненский государственный университет имени Янки Купалы» ", (short)25, (short)3, (short)11, (short)0, "80(152)-39-58-96", "Комплекс услуг участникам инновационного процесса по \r\nвведению в гражданский оборот результатов интеллектуальной деятельности, консалтинговые услуги по проектной деятельности, в том числе международной, проведение конференций и семинаров, оказание образовательных услуг по развитию инновационного предпринимательства", 270m, 0m, 0m, "https://ctt.grsu.by" },
                    { 2, "Минская область, Дзержинский район, Путчинский сельский Совет, аг. Волма, ул. Парковая, 11", 3868m, "volma@ripo.by, v_o_l_m_a@mail.ru", null, null, null, null, null, "УО РИПО «Ресурсный центр ЭкоТехнопарк-Волма»", (short)3, (short)2, (short)2, (short)0, "+375(17)374-73-31", "Услуги в проектно-консультационной, инженерно-исследо¬ватель¬ской и образовательной деятельности в целях обеспечения введения в гражданский оборот производственных и педагогических инноваций", 20m, 0m, 3.2m, "etp-volma.by" },
                    { 3, "Брестская обл. г. Барановичи, ул. Войкова, д. 21", 0m, "ctt.barsu@yandex.by", null, null, null, null, null, "УО «Барановичский государственный университет»", (short)8, (short)4, (short)12, (short)0, "80(16)364-35-85", "Научно-технические, технологические разработки, научно-исследовательская деятельность, Консалтинговые услуги, образовательные услуги, организации мероприятий для субъектов инновационной деятельности в проведении выставок, ярмарок, конференций и других мероприятий.оказание услуг по подготовке бизнес-планов инновационных проектов.", 259.7m, 0m, 0m, "http://ctt.barsu.by/" },
                    { 4, "210023, г. Витебск, пр-т Фрунзе, д. 27", 0m, "ctmft.vgmu@gmail.com", null, null, null, null, null, "УО «Витебский государственный ордена Дружбы народов медицинский университет» (в части деятельности обособленного подразделения «Центр трансфера медицинских и фармацевтических технологий»)", (short)3, (short)1, (short)1, (short)0, "", "Поиск заказчиков научных исследований, оформление проектно-смметной документации, связанной с выполнением различных видов исследований, оказание помощи в организации проведения начных исследований на базе ВГМУ, оказание помощи в оформлении и передачу отчетной документации заказчику нацчных исследований", 0m, 0m, 0.4m, "https://www.vsmu.by/about-vsmu/departments/3603-tsentr-transfera-meditsinskikh-i-farmatsevticheskikh-tekhnologij.html " },
                    { 5, "246050, г. Гомель, пр-т Ленина, д. 3, комн. 306", 0m, " mail@cntdi.gomel.by", null, null, null, null, null, "РУП «Центр научно-технической и деловой информации»", (short)10, (short)10, (short)0, (short)0, "375(232)31-58-59", "информационные услуги", 0m, 0m, 85.7m, "https://cntdi.gomel.by/" },
                    { 6, "231300, г. Лида,  Гродненская обл, ул. Советская, д. 43", 0m, "lidabi@mail.ru", null, null, null, null, null, "ООО «Апсель»", (short)6, (short)1, (short)1, (short)0, "375(29)624-91-56", "Оказание офисных услуг партнёрам, предоставление в аренду оборудования, компьютерной и офисной техники, осуществление маркетингового поиска новых технологий и источников финансирования", 0m, 0m, 19.99m, "" }
                });

            migrationBuilder.InsertData(
                table: "Technoparks",
                columns: new[] { "Id", "AddressTechnopark", "AmountFunding", "EmailTechnopark", "FreeAreaPremises", "NameImageTeh_1", "NameImageTeh_2", "NameImageTeh_3", "NameImageTeh_4", "NameImageTeh_5", "NameTechnopark", "NumberEmployees", "PhoneTechnopark", "ServicesProvided", "TechInfrastructure", "TechSpecialization", "TotalAreaPremises", "TotalNumberResident", "TypesProducts", "VolComplProducts", "WebsiteTechnopark" },
                values: new object[,]
                {
                    { 101, "220013, Республика Беларусь, г. Минск, ул. Я. Коласа, д. 24, к. 34/1", 17963.4m, "post@park.bntu.by", 0f, null, null, null, null, null, "Республиканское инновационное унитарное предприятие «Научно-технологический парк БНТУ «Политехник»", (short)168, "+375(17)235-59-74", "Инжиниринговые услуги (разработка конструкторской и технологической документации, постановка продукции на производство, регистрация и сертификация продукции). Консультационные услуги. Услуги в сфере управления интеллектуальной собственностью. Услуги по бизнес-планированию и привлечению финансирования. Услуги по продвижению продукции и разработок на рынке. Предоставление в аренду помещений и оборудования", "Технологическое оборудование: технологическое оборудование общепромышленного назначения, оборудование для высокоточной обработки деталей, оборудование для прототипирования, испытательное оборудование; Коворкинг.", "Медицинская техника, Технологии модификации поверхностей деталей; Автоматизация и робототехника.", 3996.6f, (short)16, "Оборудование для модификации поверхностей; Оборудование для очистки воздуха; Медицинская техника; Материалы для дорожного строительства; Оборудование и материалы для литейного производства и металлургии; Исследования и разработки, инжиниринговые услуги.", 18713.6f, "http://park.bntu.by/" },
                    { 102, "211446, Витебская обл., г. Новополоцк, ул. Блохина, 29/114мк", 1310m, "post@park.bntu.by", 0f, null, null, null, null, null, "Республиканское инновационное унитарное предприятие «Научно-технологический парк Полоцкого государственного университета»", (short)63, "", "Сдача в субаренду", "Лаборатория высоких технологий (технологическое оборудование).", "Научные исследования и разработки.", 345.83f, (short)8, "Софт, продукция металлообработки, светодиодная продукция", 2494f, "http://park.bntu.by/" },
                    { 103, "Республика Беларусь, 210038, г. Витебск, Московский пр-т, 72", 384.8m, "info@technopark-vitebsk.by", 56f, null, null, null, null, null, "Республиканское инновационное унитарное предприятие «Научно-технологический парк Витебского государственного технологического университета»", (short)137, "+375(212)22-67-44", "Сдача в аренду готовых помещений", "Бизнес-инкубатор", "Аренда производственных помещений, аренда оборудования.", 4023f, (short)8, "Металлопродукция, обувь, детские игрушки", 7172.2f, "www.technopark-vitebsk.by" },
                    { 104, "ул. Днепровской флотилии, 23; 225710 Пинск, Брестская область, Республика Беларусь", 1500m, "tpark.kozyr@gmail.com", 0f, null, null, null, null, null, "Общество с ограниченной ответственностью «Технопарк «Полесье»", (short)52, "+ 375(165)31-21-60 (приемная), +375(29)532-08-05 (директор)", "Аренда помещений различного назначения; технологический консалтинг; аутсорсинг бизнес-процессов.", "Бизнес-инкубатор; коворкинг-центр; доступ в 5 лабораторий УО «Полесский государственный", "Экоинженерия, биотехнологии, экосистемные услуги", 235.6f, (short)9, "Агробиотехнологическая продукция, системы очистки сточных вод, озонирующее оборудование, IT-продукция.", 1975.2f, "www.polessu.by" },
                    { 105, "Республика Беларусь, г. Минск, ул.Академика Курчатова, 1, к.10", 24227.5m, "unitehprombgu@gmail.com", 0f, null, null, null, null, null, "Учебно-научно-производственное республиканское унитарное предприятие «УНИТЕХПРОМ БГУ»", (short)18, "+375(17)212-09-26", "Сдача в аренду готовых помещений, оборудования, оказание услуг, бизнес-планирование", "Бизнес-инкубатор, участок прототипирования, лаборатория", "Производство, услуги в области естественных наук", 2362.7f, (short)6, "Ветеринарные препараты; лекарственные препараты; лабораторное, технологическое оборудование, медтехника; пищевые ингредиенты", 5740f, "https://unitehprom.bsu.by/" },
                    { 106, "230005, г. Гродно, ул. Гаспадарчая, 21/А", 3835m, "vasil@grsu.by", 2725.5f, null, null, null, null, null, "Республиканское унитарное предприятие «Учебно-научно-производственный центр «Технолаб»", (short)94, "+375(152)55-62-50, м.т +375(29)666-57-06", "Сдача в аренду готовых офисных и производственных помещений, конференц-зала, выставочных площадей,   офисного и технологического оборудования, доступ к интернет (оптоволокно, LAN, Wi-Fi), 3Д прототипирование и печать", "Центр коллективного пользования оборудованием, коворкинг-центры, лаборатория 3Д прототипирования и печати, лаборатория электроники", "Инновационные производства, разработка ПО", 8529.2f, (short)31, "Медицинская техника, раневые повязки, БАДы, косметические средства, электромобили, оборудования проверки состояния персонала  для допуска персонала к работе, BIM технологии, 3Д прототипирование и печать, программное обеспечение", 4159.7f, " " },
                    { 107, "г. Горки, ул. Мичурина, 5 оф. 480", 5245m, "technoparkgorki@gmail.com", 51.3f, null, null, null, null, null, "Общество с ограниченной ответственностью «Технопарк «Горки»", (short)37, " ", "Технопарк предоставляет в аренду недвижимое имущество для своих резидентов, предоставляет в аренду движимое имущество для инновационных исследований (3D принтеры, квадрокоптер с мультиспектральной камерой, лабораторное оборудование для исследования молока и крови КРС, почвы и др.), оказывает услуги по бизнес-планированию и продвижению перспективных проектов", "Бизнес-инкубатор, центр коллективного пользования оборудованием, коворкинг-центр, лаборатория", "Продвижение инновационных разработок в области сельского хозяйства", 1833.8f, (short)3, "Оборудование для системы точного земледелия, дроны для использования в сельском хозяйстве, датчики половой охоты животных и др.", 7899.8f, " " },
                    { 108, "Республика Беларусь, г.Брест, ул.Пионерская, 52, 224020", 35774.5m, "infi@bntp.by", 34.2f, null, null, null, null, null, "Закрытое акционерное общество «Брестский научно-технологический парк»", (short)574, "+375(162)53-07-63", "1. предоставление в аренду помещений; 2. предоставление в аренду движимого имущества, оборудование; 3. трансфер технологий; 4. подотовкаг и сопровождение инновационных и инвестиционных проектов; 5. Центр коллективного пользования; 6. организация и проведение мероприятий и т.д.", "Инкубатор малого предпринимательства, центр коллективного пользования, коворкинг", "Научно-производственная,инновационная", 16942.6f, (short)58, "Робототехника; IT/телекоммуникации; AI, BigData, IoT образование/исследования; приборотсроение", 59994.5f, "www.bntp.by" },
                    { 109, "г.Витебск, ул.П.Бровки, 50", 3639.5m, "zakoniporyadok.vit@gmail.com", 19f, null, null, null, null, null, "Инкубатор малого предпринимательства Общество с ограниченной ответственностью Правовая Группа «Закон и Порядок»", (short)212, "+375(29)636-03-35, +375(29)545-03-35", "Сдача в аренду готовых помещений, юридические услуги", "Бизнес-инкубатор, предоставление офисной мебели и компьютерной техники в безвозмездное пользование", "Многофункциональный", 15824f, (short)9, "Приборостроение; создание CRM систем", 10973.5f, "Сайт в разработке: http://www.linkedin.com/group/12506686/" },
                    { 110, "246000, Республика Беларусь, г.Гомель, ул.Лепешинского,7,", 3500.4m, "tp_korall@mail.ru", 1297.5f, null, null, null, null, null, "Республиканское унитарное сервисное предприятие «Агенство развития и содействия инвестициям» (Технопарк «Коралл»)", (short)754, "+375(23)221-38-86", "Сдача в арену офисных помещений, движимого имущества. Оказание инжиниринговых услуг, услуг по написанию бизнес-планов, услуг склада временного хранения", "Бизнес-инкубатор, коворкинг, конференц-зал, переговорная, зал заседаний, учебный класс, центр прототипирования, 3D-лаборатория, фаблаб", "IT-технологии, промышленное производство", 19243.8f, (short)15, "Программное обеспечение, SIP-панели", 16673.6f, "https://smartgomel.com" },
                    { 111, "246144, Республика Беларусь, г. Гомель, ул. Федюнинского, д. 17", 0m, "info@gntp.by, gomel-technopark@tut.by", 1027.2f, null, null, null, null, null, "Открытое акционерное общество «Гомельский технопарк»", (short)267, "+375(232)68-47-79", "Сдача внаем собственного недвижимого и движимого имущества, оказание помощи резидентам в реализации их бизнес-проектов, консультирование по вопросам становления и развития инновационного бизнеса, содействие в продвижении на рынок продукции (работ, услуг) резидентов, оказание информационных, полиграфических и консалтинговых услуг на протяжении всего срока действия статуса резидента технопарка", "Инкубатор малого предпринимательства", "Без специализации", 4297.6f, (short)2, "Автоматизация деятельности предприятий машиностроительной отрасли. Разработка программного обеспечения.", 21088.8f, "www.gntp.by" },
                    { 112, "Минская обл., Смолевичский район, д.Станок-водица, ул. Заводская, д.1;", 374m, "nfo@mpark.by", 189.9f, null, null, null, null, null, "Коммунальное производственно-торговое унитарное предприятие «Минский областной технопарк»", (short)177, "тел. +375(17)5555271", "Содействие в создании новых производств с новыми технологиями, содействие в осуществлении внешнеэкономическойдеятельности, предоставление на договорной основеп в соответствии с законодательством движимого и недвижимого имущества,  в том числе помещений различного функционального назначени, обеспечение освещения в средствах массовой информации деятельности технопарка и его резидентов, оказание иных услуг (выполнение инфх работ), связанных с научной, научно-технической и инновационной деятельностью технопарка", "Энергосети; Водоснабжение; Видеонаблюдение", "Услуги резидентам в предоставлении площадей и оборудования в аренду", 16518.4f, (short)6, "Электротранспорт, энергетические установки", 36610.3f, "http://mpark.by" },
                    { 113, "Республика Беларусь Могилевская область, Бобруйский район, г.Бобруйск", 3103.0m, "em@encata.net", 1980f, null, null, null, null, null, "Общество с ограниченной ответственностью «ИнКата»", (short)889, "+375(29)594-31-32", "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги", "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство", "Строительные технологии, приборостроение, шеринг-услуги", 8399f, (short)20, "Оборудование, приборы, строительные услуги, шеринг-услуги", 97925.8f, "encata.net" },
                    { 114, "Республика Беларусь Минская область, Смолевичский район, территория Индустриального парка «Великий камень», ул. Рубиновая", 2945.2m, "", 1980f, null, null, null, null, null, "Общество с ограниченной ответственностью «ИнКата»", (short)633, "", "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги", "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство", "Строительные технологии, приборостроение, шеринг-услуги", 6774f, (short)16, "Оборудование, приборы, строительные услуги, шеринг-услуги", 71541.2f, "" },
                    { 115, "Могилевская область, Бобруйский район, г.Бобруйск", 157.8m, "", 0f, null, null, null, null, null, "Общество с ограниченной ответственностью «ИнКата»", (short)256, "+375(29)594-31-32", "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги", "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство", "Строительные технологии, приборостроение, шеринг-услуги", 1625f, (short)4, "Оборудование, приборы, строительные услуги, шеринг-услуги", 26384.6f, "" },
                    { 116, "212030 г. Могилев, ул. Ленинская, д.63 ", 263.5m, "info@technopark.by", 388.47f, null, null, null, null, null, "Закрытое акционерное общество «Технологический парк Могилев»", (short)181, "+375(222)29-99-09", "Аренда помещений; Услуги по бизнес-планированию; Услуги связи; Услуги по ведению бухгалтерского учета; Услуги в сфере энергосбережения", "Бизнес-инкубатор", "Без специализации", 3439f, (short)16, "Системы управления двигателем; Зарядные станции; Кольпоскопы; Катера; Изделия из стеклопластика Оборудование для диагностики и ремонта автомобильной топливной аппаратуры", 26022f, "www.technopark.by " },
                    { 117, "220070, Республика Беларусь г. Минск, ул. Солтыса, 187, г. Минск, Партизанский просп. 8, г. Минск, ул. Центральная 47.", 362305.3m, "mgtp@tut.by", 20182.9f, null, null, null, null, null, "Общество с ограниченной ответственностью «Минский городской технопарк»", (short)1229, "факс: +375 (17)399-17-95 тел.: +375 (17)322-03", "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию", "Центр коллективного пользования оборудованием", "Производственные предприятия", 209960f, (short)47, "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля", 143385.9f, "www.mgtp.by" },
                    { 118, "220070, Республика Беларусь г. Минск, ул. Солтыса, 187, г. Минск, ул. Центральная 47", 81469.3m, "", 9582.3f, null, null, null, null, null, "Общество с ограниченной ответственностью «Минский городской технопарк»", (short)896, "", "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию", "Центр коллективного пользования оборудованием", "Производственные предприятия", 45876.6f, (short)41, "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля", 75664.8f, "" },
                    { 119, "г. Минск, Партизанский просп. 8,", 280836.0m, "", 4075.8f, null, null, null, null, null, "Общество с ограниченной ответственностью «Минский городской технопарк»", (short)333, "", "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию", "Центр коллективного пользования оборудованием", "Производственные предприятия", 150982.6f, (short)6, "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля", 67721.1f, "" },
                    { 120, "220092, г. Минск, пр. Пушкина 20, каб. 102.", 2296.7m, "snamiteplee@mail.ru", 3692f, null, null, null, null, null, "Общество с ограниченной ответственностью «Борисовский региональный технопарк»", (short)24, "+375(29)663-40-66", "Аренда помещений, Консалтинговое сопровождение, Помощь в привлечении инвестиций, Предложение лучших идей для бизнеса, Помощь  с маркетингом под ключ, Проведение обучающих семинаров, Помощь с выходом на зарубежный рынок, Помощь в привлечением грантовых субсидий  и венчурного финансирования, Организация поездок за границу, Поиск партнера в бизнес, Налоговые преференции.", "Бизнес-инкубатор, коворкинг-центр, центр коллективного пользования оборудованием ", "IT сфера, перерабатывающая промышленность", 4526.2f, (short)4, "IT стартапы, переработка промышленных отходов", 178.1f, "http://bizpark.by" },
                    { 121, "Республика Беларусь, 220037, г. Минск, пер. Козлова, д. 7В, пом. 2/1 ", 0m, "", 2493.8f, null, null, null, null, null, "Общество с ограниченной ответственностью «Технопарк Олика»", (short)0, "+375(29)674-02-19", "", "", "Без специализации", 3797.8f, (short)0, "", 0f, "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InnProjects");

            migrationBuilder.DropTable(
                name: "NtpProject");

            migrationBuilder.DropTable(
                name: "Technoparks");

            migrationBuilder.DropTable(
                name: "TechTransferCenters");

            migrationBuilder.DropTable(
                name: "GeoItems");
        }
    }
}
