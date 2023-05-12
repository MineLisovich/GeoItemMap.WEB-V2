using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeoItemMap.DAL.Migrations
{
    public partial class mig1 : Migration
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
                    Y = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GNTPandRNTPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NameProgramm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateCustomer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AreaImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityImplemOrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateTask = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thelevelstructure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameNewDevProducts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationExports = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformationNewProduct = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GNTPandRNTPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GNTPandRNTPs_GeoItems_Id",
                        column: x => x.Id,
                        principalTable: "GeoItems",
                        principalColumn: "Id");
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
                    Criterion3 = table.Column<bool>(type: "bit", nullable: false),
                    UseTechnologies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnualExportVolumeBY = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AnnualExportVolumeEUR = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ImportSubstituting = table.Column<bool>(type: "bit", nullable: false),
                    ValueAddedPerEmployee = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AddedValueProject = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NumberUpgradedJobs = table.Column<short>(type: "smallint", nullable: false),
                    NumberNewJobs = table.Column<short>(type: "smallint", nullable: false),
                    VolumeFinancing = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
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
                    TotalNumberResident = table.Column<short>(type: "smallint", nullable: false),
                    NumberEmployees = table.Column<short>(type: "smallint", nullable: false),
                    VolComplProducts = table.Column<float>(type: "real", nullable: false),
                    AmountFunding = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
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
                    VolumeTransactionsConcluded = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    NumberGeneratedProjects = table.Column<short>(type: "smallint", nullable: false),
                    VolumeGeneratedProjects = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    VolumeWorkPerformed = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    AmountFunding = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
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
                columns: new[] { "Id", "X", "Y" },
                values: new object[] { 1, 53.604725f, 26.890274f });

            migrationBuilder.InsertData(
                table: "GeoItems",
                columns: new[] { "Id", "X", "Y" },
                values: new object[] { 2, 54.929348f, 29.174215f });

            migrationBuilder.InsertData(
                table: "Technoparks",
                columns: new[] { "Id", "AddressTechnopark", "AmountFunding", "EmailTechnopark", "FreeAreaPremises", "NameTechnopark", "NumberEmployees", "PhoneTechnopark", "ServicesProvided", "TechInfrastructure", "TechSpecialization", "TotalAreaPremises", "TotalNumberResident", "TypesProducts", "VolComplProducts", "WebsiteTechnopark" },
                values: new object[] { 1, "220013, Республика Беларусь, г. Минск, ул. Я. Коласа, д. 24, к. 34/1 ", 17963.4m, "post@park.bntu.by", 0f, "Республиканское инновационное унитарное предприятие «Научно-технологический парк БНТУ «Политехник»", (short)168, "тел. +37517 235-59-74", "Инжиниринговые услуги (разработка конструкторской и технологической документации, постановка продукции на производство, регистрация и сертификация продукции). Консультационные услуги. Услуги в сфере управления интеллектуальной собственностью. Услуги по бизнес-планированию и привлечению финансирования. Услуги по продвижению продукции и разработок на рынке. Предоставление в аренду помещений и оборудования", "Технологическое оборудование: технологическое оборудование общепромышленного назначения, оборудование для высокоточной обработки деталей, оборудование для прототипирования, испытательное оборудование; Коворкинг.", "Медицинская техника, Технологии модификации поверхностей деталей; Автоматизация и робототехника.", 3996.6f, (short)16, "Оборудование для модификации поверхностей; Оборудование для очистки воздуха; Медицинская техника; Материалы для дорожного строительства; Оборудование и материалы для литейного производства и металлургии; Исследования и разработки, инжиниринговые услуги.", 18713.6f, "http://park.bntu.by/" });

            migrationBuilder.InsertData(
                table: "Technoparks",
                columns: new[] { "Id", "AddressTechnopark", "AmountFunding", "EmailTechnopark", "FreeAreaPremises", "NameTechnopark", "NumberEmployees", "PhoneTechnopark", "ServicesProvided", "TechInfrastructure", "TechSpecialization", "TotalAreaPremises", "TotalNumberResident", "TypesProducts", "VolComplProducts", "WebsiteTechnopark" },
                values: new object[] { 2, "211446, Витебская обл., г. Новополоцк, ул. Блохина, 29/114мк ", 1310m, "post@park.bntu.by", 0f, "Республиканское инновационное унитарное предприятие «Научно-технологический парк Полоцкого государственного университета» ", (short)63, " ", "Сдача в субаренду", "Лаборатория высоких технологий (технологическое оборудование).", "Научные исследования и разработки.", 345.83f, (short)8, "Софт, продукция металлообработки, светодиодная продукция", 2494f, "http://park.bntu.by/" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GNTPandRNTPs");

            migrationBuilder.DropTable(
                name: "InnProjects");

            migrationBuilder.DropTable(
                name: "Technoparks");

            migrationBuilder.DropTable(
                name: "TechTransferCenters");

            migrationBuilder.DropTable(
                name: "GeoItems");
        }
    }
}
