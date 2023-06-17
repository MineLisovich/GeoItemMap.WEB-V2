﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoItemMap.DAL.Entities;


namespace GeoItemMap.DAL.Predefined
{
    /// <summary>
    /// Заполение таблицы "InnProject"
    /// </summary>
    internal class PredefinedInnProjectList
    {
        InnProject id201 = new()
        {
            Id = 201,
            X = 53.91722324933752f,
            Y = 27.549812110887682f,
            GeoType = GeoItemType.InnProject,
            NameInnProject = "Организация биофармацевтического производства лекарственных средств на основе рекомбинантных технологий и фракционирования плазмы крови, соответствующего требованиям GMP",
            NameOrgImplementingProject = "Государственное учреждение «Республиканский научно-практический центр трансфузиологии и медицинских биотехнологий»",
            Customer = "Министерство здравоохранения Республики Беларусь",
            TermsImplementation= "2021-2024 гг.",
            GPIR = "ГПИР 2021-2025",
            DocumentByWhichGPIR = "Постановление СМ от 12.11.2021 № 642",
            LocationProjectImplementation = "г. Минск / «Великий камень», г. Ганцевичи, Брестская обл.",
            ProjectStatus = "В стадии реализации",
            InnovatProject = "Инновационность заключается в самообеспечении Республики Беларусь инновационной биотехнологической продукцией, высококачественными и безопасными отечественными лекарственными средствами из плазмы крови, генноинженерными фармсубстанциями, биомедицинским клеточным продуктом по доступным ценам, для снижения зависимости Республики Беларусь от импорта медицинских препаратов, организация экспортных поставок. Проект имеет большую социально-экономическую значимость, экспортную направленность, инновационность, высокий уровень внедряемых технологий. Создание современного биофармацевтического производства позволит: располагать собственными стратегическими для безопасности республики технологиями производства и контроля качества биотехнологических продуктов; реализовать принцип независимости государства от колебаний мирового рынка плазмы и лекарственных средств из плазмы крови; обеспечить дополнительные рабочие места; ежегодно экономить бюджетные ассигнования, при существующем объеме заготовки плазмы за счет отказа от покупки импортных лекарственных средств из плазмы крови и рекомбинантных белков; обеспечить высокую социально-экономическую эффективность и заложить экспортный потенциал ввиду высокого уровня добавленной стоимости на одного работника нового производства и наличия уникальных отечественных биофармацевтических технологий; обеспечить экспорт биотехнологической продукции.",
            ProductsRelease = "Планируются к производству новые иинновационные лекарственные средства: иммуноглобулин человека для внутривенного введения (иммунологический препарат, обладает антибактериальными, противовирусными свойствами, неспецифической иммунорегуляторной активностью); концентрат факторов протромбинового комплекса (ППСБ) (гемостатическое средство для внутривенного введения, используется для профилактики кровотечений при приобретенном дефиците факторов протромбинового комплекса и врожденном дефиците одного из витамин К-зависимых факторов свертывания); Плазмабел (вирусинактивированная криоплазма), Нормоплаз (сухая плазма, патогенредуцированная е пролонгированным сроком хранения); Концентрат фактора VIII (антигемофильное лекарственное средство для терапии и профилактика кровотечений у пациентов с врожденньш (гемофилия А) и приобретенным дефицитом фактора). Инновационный проект предусматривает организацию промышленного производства рекомбинантных фармсубстанций по разработанным технологиям: фармацевтическая субстанция человеческого рекомбинантного интерферона альфа 2Ь, продуцируется генетически измененным штаммом бактерии EscherichiacoHBL21 (DE3)/pET - интерферон альфа 2Ь, обладает неспецифнчеекой противовирусной и антапролиферативной активностью, оказывает угнетающее влияние на синтез некоторых онкогенов, приводящее к ингибированию опухолевого роста; фармацевтическая субстанция человеческого рекомбинантного гранулоцитарного колониестимулирующего фактора (филграстим), продуцируется генетически измененным штаммом бактерии EscherichiacoKBL21 (DE3)/pET-r-КСФ, в геном которой методами генной инженерии введен ген гранулоцитарного колониестимулирующего фактора человека. Стимулятор лейкопоэза, регулирующий образование функционально активных нейтрофилов и их выход в кровь из костного мозга, значительно уменьшает частоту тяжесть и продолжительность нейтропении при химиотерапии цитостатикамии др.Также запланировано производство новых инновационных изделий медицинского назначения: клей хирургический двухкомпонентный на основе альбумина для герметизации и укрепления хирургических швов, склеивания тканей; плазма обогащенная ростовыми факторами тромбоцитов. Планируется производство биомедицинского клеточного продукта.",
            TypeEconomicActivity = "Секция Q* Здравоохранение и социальные услуги Подсекция QA: Здравоохранение Код раздела 86: Здравоохранение",
            Criterion1 = 74359.9m,
            Criterion2 = 5700.0m,
            Criterion3 = "Новизна для Республики Беларусь",
            UseTechnologies = "1;2",
            AnnualProductionVolumeBY = 17704.7m,
            AnnualExportVolumeBY = 10371.1m,
            AnnualExportVolumeEUR = 4203.1m,
            ImportSubstituting = "Проект не направлен на импортозамещение",
            ValueAddedPerEmployee = 186.4m,
            AddedValueProject = 16778.1m,
            NumberUpgradedJobs = 70,
            NumberNewJobs = 20,
            VolumeFinancing = 90233.4m,

        };

        InnProject id202 = new()
        {
            Id = 202,
            X = 53.902890562497745f,
            Y = 27.51201986727323f,
            GeoType = GeoItemType.InnProject,
            NameInnProject = "Создание опытно-промышленного производства твердых лекарственных форм с применением инновационных технологий",
            NameOrgImplementingProject = "Республиканское производственное унитарное предприятие «АКАДЕМФАРМ»",
            Customer = "Национальная академия наук Беларуси",
            TermsImplementation = "2020-2025 гг.",
            GPIR = "ГПИР 2021-2025",
            DocumentByWhichGPIR = "Постановление СМ от 12.11.2021 № 642",
            LocationProjectImplementation = "г. Минск",
            ProjectStatus = "В стадии реализации",
            InnovatProject = "Инновационная направленность реализации проекта «Создание опытно-промышленного производства твердых лекарственных форм с применением инновационных технологий» заключается в инновационности применяемых технологических решений.В части локализации производства на территории Республики Беларусь эффективных и безопасных лекарственных средств для лечения социально-значимых заболеваний: ВИЧ-инфекции, гепатита В, болезни Альцгеймера, подагры, эпилепсии, ревматоидного артрита, тромбоэмболии и др. Актуальной тенденцией в области рассматриваемой проблемы является использование экструзии горячих расплавов. Эта технология является инновационной для фармацевтической промышленности, о чем свидетельствуют последние разработки зарубежных ученых.",
            ProductsRelease = "Производство широкого ассортимента лекарственных средств, в частности: антиретровирусные препараты; препаратов для лечения нервной системы, болезни Альцгеймера; Препаратов для лечения вирусных гепатитов; препаратов для лечения костно-мышечных заболеваний; препаратов для лечения бронхиальной астмы; антикоагулянта",
            TypeEconomicActivity = "С21201( производство основных фармацевтических продуктов и прапаратов)",
            Criterion1 = 184659.0m,
            Criterion2 = 3063.5m,
            Criterion3 = "Новизна для Республики Беларусь",
            UseTechnologies = "2",
            AnnualProductionVolumeBY = 46396.1m,
            AnnualExportVolumeBY = 10117.8m,
            AnnualExportVolumeEUR = 0,
            ImportSubstituting = "Проект не направлен на импортозамещение",
            ValueAddedPerEmployee = 784.3m,
            AddedValueProject = 8832.4m,
            NumberUpgradedJobs = 0,
            NumberNewJobs = 21,
            VolumeFinancing = 7835.0m,
        };

        InnProject id203 = new()
        {
            Id = 203,
            X = 54.18973418974246f,
            Y = 28.492611412744306f,
            GeoType = GeoItemType.InnProject,
            NameInnProject = "«Создание современного гибкого автоматизированного производства узлов рулевого управления для комплектации автомобильной техники»",
            NameOrgImplementingProject = "Открытое Акционерное Общество «Борисовский завод «Автогидроусилитель»",
            Customer = "Министерство промышленности Республики Беларусь",
            TermsImplementation = "2017-2023 гг.",
            GPIR = "ГПИР (2016-2020 гг.; 2021-2025 гг.)",
            DocumentByWhichGPIR = "Постановление СМ от 20.12.2017 № 977",
            LocationProjectImplementation = "Минская обл., г.Борисов, ул.Чапаева, 56.",
            ProjectStatus = "В стадии реализации",
            InnovatProject = "По результатам реализации проекта предполагается к выпуску новая и модернизированная продукция, а также предусматривается замещение жёстких производственных линий на гибкие быстро переналаживаемые линии по производству рулевых систем для автомобилей, оптимизацию использования производственных площадей путем размещения производств на одной производственной площадке. Эти изделия относятся к наукоемкой, высокотехнологичной, импортозамещающей продукции и используется в производстве автомобилей и автобусов. Изделия будут иметь технические характеристики на уровне мировых аналогов и конкурентную цену, а отсутствие аналогов в Республике Беларусь, позволит заместить импортные поставки, а также расширить рынок поставок рулевых систем в страны ближнего и дальнего зарубежья.",
            ProductsRelease = "Механизмы рулевого управления,насосы общепромышленного применения,гидравлические системы, гидроцилиндры",
            TypeEconomicActivity = "Секция С «Обрабатывающая промышленность№ ; Подсекция CL» производство транспортных средств и оборудования» раздел 29",
            Criterion1 = 79.7m,
            Criterion2 = 58479.8m,
            Criterion3 = "Новизна для Республики Беларусь",
            UseTechnologies = "3",
            AnnualProductionVolumeBY = 136492.7m,
            AnnualExportVolumeBY = 103870.9m,
            AnnualExportVolumeEUR = 0,
            ImportSubstituting = "Проект не направлен на импортозамещение",
            ValueAddedPerEmployee = 181.5m,
            AddedValueProject = 49728.9m,
            NumberUpgradedJobs = 0,
            NumberNewJobs = 43,
            VolumeFinancing = 56652.5m,
        };

        internal List<InnProject> innProjects;
        internal PredefinedInnProjectList() 
        {
            innProjects = new()
            { 
                id201, id202, id203
            };
        }
    }
}
