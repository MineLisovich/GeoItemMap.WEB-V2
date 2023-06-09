﻿using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GeoItemMap.DAL.Predefined.RegionTypeEnum;

namespace GeoItemMap.DAL.Predefined
{
    /// <summary>
    /// Заполнение таблицы "Technopark"
    /// </summary>
    internal class PredefinedTechnoparkList
    {
        Technopark id101 = new()
        {
            Id = 101,
            X = 53.92567633515678f,
            Y = 27.59164037040133f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Республиканское инновационное унитарное предприятие «Научно-технологический парк БНТУ «Политехник»",
            AddressTechnopark = "220013, Республика Беларусь, г. Минск, ул. Я. Коласа, д. 24, к. 34/1",
            PhoneTechnopark = "+375(17)235-59-74",
            EmailTechnopark = "post@park.bntu.by",
            WebsiteTechnopark = "http://park.bntu.by/",
            TotalAreaPremises = 3996.6f,
            FreeAreaPremises = 0,
            TechSpecialization = "Медицинская техника, Технологии модификации поверхностей деталей; Автоматизация и робототехника.",
            TypesProducts = "Оборудование для модификации поверхностей; Оборудование для очистки воздуха; Медицинская техника; Материалы для дорожного строительства; Оборудование и материалы для литейного производства и металлургии; Исследования и разработки, инжиниринговые услуги.",
            ServicesProvided = "Инжиниринговые услуги (разработка конструкторской и технологической документации, постановка продукции на производство, регистрация и сертификация продукции). Консультационные услуги. Услуги в сфере управления интеллектуальной собственностью. Услуги по бизнес-планированию и привлечению финансирования. Услуги по продвижению продукции и разработок на рынке. Предоставление в аренду помещений и оборудования",
            TechInfrastructure = "Технологическое оборудование: технологическое оборудование общепромышленного назначения, оборудование для высокоточной обработки деталей, оборудование для прототипирования, испытательное оборудование; Коворкинг.",
            TotalNumberResident = 16,
            NumberEmployees = 168,
            VolComplProducts = 18713.6f,
            AmountFunding = 17963.4m
        };

        Technopark id102 = new()
        { 
            Id = 102,
            X = 55.5308526728631f,
            Y = 28.647307334957322f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.VitebskRegion,
            NameTechnopark = "Республиканское инновационное унитарное предприятие «Научно-технологический парк Полоцкого государственного университета»",
            AddressTechnopark = "211446, Витебская обл., г. Новополоцк, ул. Блохина, 29/114мк",
            PhoneTechnopark = "",
            EmailTechnopark = "post@park.bntu.by",
            WebsiteTechnopark = "http://park.bntu.by/",
            TotalAreaPremises = 345.83f,
            FreeAreaPremises = 0,
            TechSpecialization = "Научные исследования и разработки.",
            TypesProducts = "Софт, продукция металлообработки, светодиодная продукция",
            ServicesProvided = "Сдача в субаренду",
            TechInfrastructure = "Лаборатория высоких технологий (технологическое оборудование).",
            TotalNumberResident = 8,
            NumberEmployees = 63,
            VolComplProducts = 2494f,
            AmountFunding = 1310m
        };

        Technopark id103 = new()
        {
            Id = 103,
            X = 55.17835313506437f,
            Y = 30.2379711410224f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.VitebskRegion,
            NameTechnopark = "Республиканское инновационное унитарное предприятие «Научно-технологический парк Витебского государственного технологического университета»",
            AddressTechnopark = "Республика Беларусь, 210038, г. Витебск, Московский пр-т, 72",
            PhoneTechnopark = "+375(212)22-67-44",
            EmailTechnopark = "info@technopark-vitebsk.by",
            WebsiteTechnopark = "www.technopark-vitebsk.by",
            TotalAreaPremises = 4023f,
            FreeAreaPremises = 56,
            TechSpecialization = "Аренда производственных помещений, аренда оборудования.",
            TypesProducts = "Металлопродукция, обувь, детские игрушки",
            ServicesProvided = "Сдача в аренду готовых помещений",
            TechInfrastructure = "Бизнес-инкубатор",
            TotalNumberResident = 8,
            NumberEmployees = 137,
            VolComplProducts = 7172.2f,
            AmountFunding = 384.8m
        };

        Technopark id104 = new()
        {
            Id = 104,
            X = 52.11355704908594f,
            Y = 26.112936897306287f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.BrestRegion,
            NameTechnopark = "Общество с ограниченной ответственностью «Технопарк «Полесье»",
            AddressTechnopark = "ул. Днепровской флотилии, 23; 225710 Пинск, Брестская область, Республика Беларусь",
            PhoneTechnopark = "+ 375(165)31-21-60 (приемная), +375(29)532-08-05 (директор)",
            EmailTechnopark = "tpark.kozyr@gmail.com",
            WebsiteTechnopark = "www.polessu.by",
            TotalAreaPremises = 235.6f,
            FreeAreaPremises = 0,
            TechSpecialization = "Экоинженерия, биотехнологии, экосистемные услуги",
            TypesProducts = "Агробиотехнологическая продукция, системы очистки сточных вод, озонирующее оборудование, IT-продукция.",
            ServicesProvided = "Аренда помещений различного назначения; технологический консалтинг; аутсорсинг бизнес-процессов.",
            TechInfrastructure = "Бизнес-инкубатор; коворкинг-центр; доступ в 5 лабораторий УО «Полесский государственный",
            TotalNumberResident = 9,
            NumberEmployees = 52,
            VolComplProducts = 1975.2f,
            AmountFunding = 1500m
        };

        Technopark id105 = new()
        {
            Id = 105,
            X = 53.840141696055746f,
            Y = 27.477471208866287f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Учебно-научно-производственное республиканское унитарное предприятие «УНИТЕХПРОМ БГУ»",
            AddressTechnopark = "Республика Беларусь, г. Минск, ул.Академика Курчатова, 1, к.10",
            PhoneTechnopark = "+375(17)212-09-26",
            EmailTechnopark = "unitehprombgu@gmail.com",
            WebsiteTechnopark = "https://unitehprom.bsu.by/",
            TotalAreaPremises = 2362.7f,
            FreeAreaPremises = 0,
            TechSpecialization = "Производство, услуги в области естественных наук",
            TypesProducts = "Ветеринарные препараты; лекарственные препараты; лабораторное, технологическое оборудование, медтехника; пищевые ингредиенты",
            ServicesProvided = "Сдача в аренду готовых помещений, оборудования, оказание услуг, бизнес-планирование",
            TechInfrastructure = "Бизнес-инкубатор, участок прототипирования, лаборатория",
            TotalNumberResident = 6,
            NumberEmployees = 18,
            VolComplProducts = 5740f,
            AmountFunding = 24227.5m
        };

        Technopark id106 = new()
        {
            Id = 106,
            X = 53.71121573321226f,
            Y = 23.82643476489058f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.GrodnoRegion,
            NameTechnopark = "Республиканское унитарное предприятие «Учебно-научно-производственный центр «Технолаб»",
            AddressTechnopark = "230005, г. Гродно, ул. Гаспадарчая, 21/А",
            PhoneTechnopark = "+375(152)55-62-50, м.т +375(29)666-57-06",
            EmailTechnopark = "vasil@grsu.by",
            WebsiteTechnopark = " ",
            TotalAreaPremises = 8529.2f,
            FreeAreaPremises = 2725.5f,
            TechSpecialization = "Инновационные производства, разработка ПО",
            TypesProducts = "Медицинская техника, раневые повязки, БАДы, косметические средства, электромобили, оборудования проверки состояния персонала  для допуска персонала к работе, BIM технологии, 3Д прототипирование и печать, программное обеспечение",
            ServicesProvided = "Сдача в аренду готовых офисных и производственных помещений, конференц-зала, выставочных площадей,   офисного и технологического оборудования, доступ к интернет (оптоволокно, LAN, Wi-Fi), 3Д прототипирование и печать",
            TechInfrastructure = "Центр коллективного пользования оборудованием, коворкинг-центры, лаборатория 3Д прототипирования и печати, лаборатория электроники",
            TotalNumberResident = 31,
            NumberEmployees = 94,
            VolComplProducts = 4159.7f,
            AmountFunding = 3835m
        };

        Technopark id107 = new()
        { 
            Id = 107,
            X = 54.29028668193705f,
            Y = 30.987661243257918f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MogilevRegion,
            NameTechnopark = "Общество с ограниченной ответственностью «Технопарк «Горки»",
            AddressTechnopark = "г. Горки, ул. Мичурина, 5 оф. 480",
            PhoneTechnopark = " ",
            EmailTechnopark = "technoparkgorki@gmail.com",
            WebsiteTechnopark = " ",
            TotalAreaPremises = 1833.8f,
            FreeAreaPremises = 51.3f,
            TechSpecialization = "Продвижение инновационных разработок в области сельского хозяйства",
            TypesProducts = "Оборудование для системы точного земледелия, дроны для использования в сельском хозяйстве, датчики половой охоты животных и др.",
            ServicesProvided = "Технопарк предоставляет в аренду недвижимое имущество для своих резидентов, предоставляет в аренду движимое имущество для инновационных исследований (3D принтеры, квадрокоптер с мультиспектральной камерой, лабораторное оборудование для исследования молока и крови КРС, почвы и др.), оказывает услуги по бизнес-планированию и продвижению перспективных проектов",
            TechInfrastructure = "Бизнес-инкубатор, центр коллективного пользования оборудованием, коворкинг-центр, лаборатория",
            TotalNumberResident = 3,
            NumberEmployees = 37,
            VolComplProducts = 7899.8f,
            AmountFunding = 5245m
        };

        Technopark id108 = new()
        {
            Id = 108,
            X = 52.09722412768465f,
            Y = 23.731107595461975f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.BrestRegion,
            NameTechnopark = "Закрытое акционерное общество «Брестский научно-технологический парк»",
            AddressTechnopark = "Республика Беларусь, г.Брест, ул.Пионерская, 52, 224020",
            PhoneTechnopark = "+375(162)53-07-63",
            EmailTechnopark = "infi@bntp.by",
            WebsiteTechnopark = "www.bntp.by",
            TotalAreaPremises = 16942.6f,
            FreeAreaPremises = 34.2f,
            TechSpecialization = "Научно-производственная,инновационная",
            TypesProducts = "Робототехника; IT/телекоммуникации; AI, BigData, IoT образование/исследования; приборотсроение",
            ServicesProvided = "1. предоставление в аренду помещений; 2. предоставление в аренду движимого имущества, оборудование; 3. трансфер технологий; 4. подотовкаг и сопровождение инновационных и инвестиционных проектов; 5. Центр коллективного пользования; 6. организация и проведение мероприятий и т.д.",
            TechInfrastructure = "Инкубатор малого предпринимательства, центр коллективного пользования, коворкинг",
            TotalNumberResident = 58,
            NumberEmployees = 574,
            VolComplProducts = 59994.5f,
            AmountFunding = 35774.5m
        };

        Technopark id109 = new()
        {
            Id = 109,
            X = 55.1589891640668f,
            Y = 30.23544833706945f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.VitebskRegion,
            NameTechnopark = "Инкубатор малого предпринимательства Общество с ограниченной ответственностью Правовая Группа «Закон и Порядок»",
            AddressTechnopark = "г.Витебск, ул.П.Бровки, 50",
            PhoneTechnopark = "+375(29)636-03-35, +375(29)545-03-35",
            EmailTechnopark = "zakoniporyadok.vit@gmail.com",
            WebsiteTechnopark = "Сайт в разработке: http://www.linkedin.com/group/12506686/",
            TotalAreaPremises = 15824f,
            FreeAreaPremises = 19f,
            TechSpecialization = "Многофункциональный",
            TypesProducts = "Приборостроение; создание CRM систем",
            ServicesProvided = "Сдача в аренду готовых помещений, юридические услуги",
            TechInfrastructure = "Бизнес-инкубатор, предоставление офисной мебели и компьютерной техники в безвозмездное пользование",
            TotalNumberResident = 9,
            NumberEmployees = 212,
            VolComplProducts = 10973.5f,
            AmountFunding = 3639.5m
        };

        Technopark id110 = new()
        {
            Id = 110,
            X = 52.47443040759271f,
            Y = 30.99671002098027f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.GomelRegion,
            NameTechnopark = "Республиканское унитарное сервисное предприятие «Агенство развития и содействия инвестициям» (Технопарк «Коралл»)",
            AddressTechnopark = "246000, Республика Беларусь, г.Гомель, ул.Лепешинского,7,",
            PhoneTechnopark = "+375(23)221-38-86",
            EmailTechnopark = "tp_korall@mail.ru",
            WebsiteTechnopark = "https://smartgomel.com",
            TotalAreaPremises = 19243.8f,
            FreeAreaPremises = 1297.5f,
            TechSpecialization = "IT-технологии, промышленное производство",
            TypesProducts = "Программное обеспечение, SIP-панели",
            ServicesProvided = "Сдача в арену офисных помещений, движимого имущества. Оказание инжиниринговых услуг, услуг по написанию бизнес-планов, услуг склада временного хранения",
            TechInfrastructure = "Бизнес-инкубатор, коворкинг, конференц-зал, переговорная, зал заседаний, учебный класс, центр прототипирования, 3D-лаборатория, фаблаб",
            TotalNumberResident = 15,
            NumberEmployees = 754,
            VolComplProducts = 16673.6f,
            AmountFunding = 3500.4m
        };

        Technopark id111 = new()
        {   
            Id = 111,
            X = 52.47978318969016f,
            Y = 30.989746541497514f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.GomelRegion,
            NameTechnopark = "Открытое акционерное общество «Гомельский технопарк»",
            AddressTechnopark = "246144, Республика Беларусь, г. Гомель, ул. Федюнинского, д. 17",
            PhoneTechnopark = "+375(232)68-47-79",
            EmailTechnopark = "info@gntp.by, gomel-technopark@tut.by",
            WebsiteTechnopark = "www.gntp.by",
            TotalAreaPremises = 4297.6f,
            FreeAreaPremises = 1027.2f,
            TechSpecialization = "Без специализации",
            TypesProducts = "Автоматизация деятельности предприятий машиностроительной отрасли. Разработка программного обеспечения.",
            ServicesProvided = "Сдача внаем собственного недвижимого и движимого имущества, оказание помощи резидентам в реализации их бизнес-проектов, консультирование по вопросам становления и развития инновационного бизнеса, содействие в продвижении на рынок продукции (работ, услуг) резидентов, оказание информационных, полиграфических и консалтинговых услуг на протяжении всего срока действия статуса резидента технопарка",
            TechInfrastructure = "Инкубатор малого предпринимательства",
            TotalNumberResident = 2,
            NumberEmployees = 267,
            VolComplProducts = 21088.8f,
            AmountFunding = 0
        };

        Technopark id112 = new()
        { 
            Id = 112,
            X = 53.9790453151712f,
            Y = 28.027534338974498f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MinskRegion,
            NameTechnopark = "Коммунальное производственно-торговое унитарное предприятие «Минский областной технопарк»",
            AddressTechnopark = "Минская обл., Смолевичский район, д.Станок-водица, ул. Заводская, д.1;",
            PhoneTechnopark = "тел. +375(17)5555271",
            EmailTechnopark = "nfo@mpark.by",
            WebsiteTechnopark = "http://mpark.by",
            TotalAreaPremises = 16518.4f,
            FreeAreaPremises = 189.9f,
            TechSpecialization = "Услуги резидентам в предоставлении площадей и оборудования в аренду",
            TypesProducts = "Электротранспорт, энергетические установки",
            ServicesProvided = "Содействие в создании новых производств с новыми технологиями, содействие в осуществлении внешнеэкономическойдеятельности, предоставление на договорной основеп в соответствии с законодательством движимого и недвижимого имущества,  в том числе помещений различного функционального назначени, обеспечение освещения в средствах массовой информации деятельности технопарка и его резидентов, оказание иных услуг (выполнение инфх работ), связанных с научной, научно-технической и инновационной деятельностью технопарка",
            TechInfrastructure = "Энергосети; Водоснабжение; Видеонаблюдение",
            TotalNumberResident = 6,
            NumberEmployees = 177,
            VolComplProducts = 36610.3f,
            AmountFunding = 374m
        };

        Technopark id113 = new()
        {
            Id = 113,
            X = 53.1444055529557f,
            Y = 29.21944917656991f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MogilevRegion,
            NameTechnopark = "Общество с ограниченной ответственностью «ИнКата»",
            AddressTechnopark = "Республика Беларусь Могилевская область, Бобруйский район, г.Бобруйск",
            PhoneTechnopark = "+375(29)594-31-32",
            EmailTechnopark = "em@encata.net",
            WebsiteTechnopark = "encata.net",
            TotalAreaPremises = 8399f,
            FreeAreaPremises = 1980f,
            TechSpecialization = "Строительные технологии, приборостроение, шеринг-услуги",
            TypesProducts = "Оборудование, приборы, строительные услуги, шеринг-услуги",
            ServicesProvided = "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги",
            TechInfrastructure = "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство",
            TotalNumberResident = 20,
            NumberEmployees = 889,
            VolComplProducts = 97925.8f,
            AmountFunding = 3103.0m
        };

        Technopark id114 = new()
        { 
            Id = 114,
            X = 53.834773442486274f,
            Y = 28.01154196575519f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MinskRegion,
            NameTechnopark = "Общество с ограниченной ответственностью «ИнКата»",
            AddressTechnopark = "Республика Беларусь Минская область, Смолевичский район, территория Индустриального парка «Великий камень», ул. Рубиновая",
            PhoneTechnopark = "",
            EmailTechnopark = "",
            WebsiteTechnopark = "",
            TotalAreaPremises = 6774f,
            FreeAreaPremises = 1980f,
            TechSpecialization = "Строительные технологии, приборостроение, шеринг-услуги",
            TypesProducts = "Оборудование, приборы, строительные услуги, шеринг-услуги",
            ServicesProvided = "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги",
            TechInfrastructure = "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство",
            TotalNumberResident = 16,
            NumberEmployees = 633,
            VolComplProducts = 71541.2f,
            AmountFunding = 2945.2m
        };

        Technopark id115 = new()
        {
            Id = 115,
            X = 53.148197359817196f,
            Y = 29.21452660113076f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MogilevRegion,
            NameTechnopark = "Общество с ограниченной ответственностью «ИнКата»",
            AddressTechnopark = "Могилевская область, Бобруйский район, г.Бобруйск",
            PhoneTechnopark = "+375(29)594-31-32",
            EmailTechnopark = "",
            WebsiteTechnopark = "",
            TotalAreaPremises = 1625f,
            FreeAreaPremises = 0,
            TechSpecialization = "Строительные технологии, приборостроение, шеринг-услуги",
            TypesProducts = "Оборудование, приборы, строительные услуги, шеринг-услуги",
            ServicesProvided = "Сдача в аренду готовых помещений, телефонная связь, инжиниринговые и консалтинговые услуги",
            TechInfrastructure = "Центр коллективного пользования оборудованием, центр прототипирования, коворкинг, конструкторское бюро и опытное производство",
            TotalNumberResident = 4,
            NumberEmployees = 256,
            VolComplProducts = 26384.6f,
            AmountFunding = 157.8m
        };

        Technopark id116 = new()
        {
            Id = 116,
            X = 53.904914836639385f,
            Y = 30.343761583298324f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.MogilevRegion,
            NameTechnopark = "Закрытое акционерное общество «Технологический парк Могилев»",
            AddressTechnopark = "212030 г. Могилев, ул. Ленинская, д.63 ",
            PhoneTechnopark = "+375(222)29-99-09",
            EmailTechnopark = "info@technopark.by",
            WebsiteTechnopark = "www.technopark.by ",
            TotalAreaPremises = 3439f,
            FreeAreaPremises = 388.47f,
            TechSpecialization = "Без специализации",
            TypesProducts = "Системы управления двигателем; Зарядные станции; Кольпоскопы; Катера; Изделия из стеклопластика Оборудование для диагностики и ремонта автомобильной топливной аппаратуры",
            ServicesProvided = "Аренда помещений; Услуги по бизнес-планированию; Услуги связи; Услуги по ведению бухгалтерского учета; Услуги в сфере энергосбережения",
            TechInfrastructure = "Бизнес-инкубатор",
            TotalNumberResident = 16,
            NumberEmployees = 181,
            VolComplProducts = 26022f,
            AmountFunding = 263.5m
        };

        Technopark id117 = new()
        { 
            Id = 117,
            X = 53.90276131310699f,
            Y = 27.644878153217267f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Общество с ограниченной ответственностью «Минский городской технопарк»",
            AddressTechnopark = "220070, Республика Беларусь г. Минск, ул. Солтыса, 187, г. Минск, Партизанский просп. 8, г. Минск, ул. Центральная 47.",
            PhoneTechnopark = "факс: +375 (17)399-17-95 тел.: +375 (17)322-03",
            EmailTechnopark = "mgtp@tut.by",
            WebsiteTechnopark = "www.mgtp.by",
            TotalAreaPremises = 209960f,
            FreeAreaPremises = 20182.9f,
            TechSpecialization = "Производственные предприятия",
            TypesProducts = "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля",
            ServicesProvided = "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию",
            TechInfrastructure = "Центр коллективного пользования оборудованием",
            TotalNumberResident = 47,
            NumberEmployees = 1229,
            VolComplProducts = 143385.9f,
            AmountFunding = 362305.3m
        };

        Technopark id118 = new()
        { 
            Id = 118,
            X = 53.87585567326809f,
            Y = 27.65573779739013f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Общество с ограниченной ответственностью «Минский городской технопарк»",
            AddressTechnopark = "220070, Республика Беларусь г. Минск, ул. Солтыса, 187, г. Минск, ул. Центральная 47",
            PhoneTechnopark = "",
            EmailTechnopark = "",
            WebsiteTechnopark = "",
            TotalAreaPremises = 45876.6f,
            FreeAreaPremises = 9582.3f,
            TechSpecialization = "Производственные предприятия",
            TypesProducts = "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля",
            ServicesProvided = "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию",
            TechInfrastructure = "Центр коллективного пользования оборудованием",
            TotalNumberResident = 41,
            NumberEmployees = 896,
            VolComplProducts = 75664.8f,
            AmountFunding = 81469.3m
        };

        Technopark id119 = new()
        {      
            Id = 119,
            X = 53.88312835044696f,
            Y = 27.592126329339663f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Общество с ограниченной ответственностью «Минский городской технопарк»",
            AddressTechnopark = "г. Минск, Партизанский просп. 8,",
            PhoneTechnopark = "",
            EmailTechnopark = "",
            WebsiteTechnopark = "",
            TotalAreaPremises = 150982.6f,
            FreeAreaPremises = 4075.8f,
            TechSpecialization = "Производственные предприятия",
            TypesProducts = "Проведение НИОК(Т)Р в различных областях науки и техники; Зеленая энергетика, переработка отходов, защита окружающей среды;  Фармакология и биотехнологии; Микроэлектроника широкого профиля; Робототехника; Системы безопасности и контроля доступа; Лазерная техника, оптические приборы; Точное приборостроение и обработка материалов; Инжиниринговые услуги широкого профиля",
            ServicesProvided = "Сдача в аренду готовых помещений;  специализированный консалтинг; содействие в доступе к финансовым, организационным и административным ресурсам; доступ к технологическому оборудованию",
            TechInfrastructure = "Центр коллективного пользования оборудованием",
            TotalNumberResident = 6,
            NumberEmployees = 333,
            VolComplProducts = 67721.1f,
            AmountFunding = 280836.0m
        };

        Technopark id120 = new()
        {
            Id = 120,
            X = 53.9011144121389f,
            Y = 27.497474368556322f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Общество с ограниченной ответственностью «Борисовский региональный технопарк»",
            AddressTechnopark = "220092, г. Минск, пр. Пушкина 20, каб. 102.",
            PhoneTechnopark = "+375(29)663-40-66",
            EmailTechnopark = "snamiteplee@mail.ru",
            WebsiteTechnopark = "http://bizpark.by",
            TotalAreaPremises = 4526.2f,
            FreeAreaPremises = 3692f,
            TechSpecialization = "IT сфера, перерабатывающая промышленность",
            TypesProducts = "IT стартапы, переработка промышленных отходов",
            ServicesProvided = "Аренда помещений, Консалтинговое сопровождение, Помощь в привлечении инвестиций, Предложение лучших идей для бизнеса, Помощь  с маркетингом под ключ, Проведение обучающих семинаров, Помощь с выходом на зарубежный рынок, Помощь в привлечением грантовых субсидий  и венчурного финансирования, Организация поездок за границу, Поиск партнера в бизнес, Налоговые преференции.",
            TechInfrastructure = "Бизнес-инкубатор, коворкинг-центр, центр коллективного пользования оборудованием ",
            TotalNumberResident = 4,
            NumberEmployees = 24,
            VolComplProducts = 178.1f,
            AmountFunding = 2296.7m
        };

        Technopark id121 = new()
        { 
            Id = 121,
            X = 53.897048074975075f,
            Y = 27.59973225506066f,
            GeoType = GeoItemType.Technopark,
            Region = RegionType.Minsk,
            NameTechnopark = "Общество с ограниченной ответственностью «Технопарк Олика»",
            AddressTechnopark = "Республика Беларусь, 220037, г. Минск, пер. Козлова, д. 7В, пом. 2/1 ",
            PhoneTechnopark = "+375(29)674-02-19",
            EmailTechnopark = "",
            WebsiteTechnopark = "",
            TotalAreaPremises = 3797.8f,
            FreeAreaPremises = 2493.8f,
            TechSpecialization = "Без специализации",
            TypesProducts = "",
            ServicesProvided = "",
            TechInfrastructure = "",
            TotalNumberResident = 0,
            NumberEmployees = 0,
            VolComplProducts = 0,
            AmountFunding = 0
        };

        internal List<Technopark> Technoparks;

        internal PredefinedTechnoparkList()
        {
            Technoparks = new()
            {
                id101, id102, id103, id104, id105, id106, id107, id108, id109, id110,
                id111, id112, id113, id114, id115, id116, id117, id118, id119, id120, id121
            };
        }
    }
}
