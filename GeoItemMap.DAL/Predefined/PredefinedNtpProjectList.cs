using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class PredefinedNtpProjectList
    {
        NtpProject id1001 = new()
        {

         
            Id = 1001,
            X = 53.93870244340076f,
            Y = 27.602226268558294f,
            GeoType = GeoItemType.NtpProject,
            NameProgramm = "РО3.15",
            StateCustomer = "",
            ParentImplemOrg = "ОАО «МНИПИ»",
            ImplemOrg = "ОАО «МНИПИ»",
            AdressImplemOrg = "Республика Беларусь,Минская область, г. Минск ",
            NameTask = "«Разработать и освоить производство подвижного информационного комплекса», шифр «Контент»",
            StateTask = "",
            TheLevelStructure = "V технологический уклад",
            NameNewDevProducts = "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.",
            InformationExports = "",
            InformationNewProduct = ""
        };

        NtpProject id1002 = new()
        {
            Id = 1002,
            X = 55.16762421872135f,
            Y = 30.23936292628765f,
            GeoType = GeoItemType.NtpProject,
            NameProgramm = "БПТ_14",
            StateCustomer = "",
            ParentImplemOrg = "ОАО «Витязь»",
            ImplemOrg = "ОАО «Витязь»",
            AdressImplemOrg = "Республика Беларусь,Витебская область, г. Витебск",
            NameTask = "«Разработать и освоить в серийном производстве стационарную электрозарядную станцию постоянного тока для легковых электромобилей»",
            StateTask = "",
            TheLevelStructure = "V технологический уклад",
            NameNewDevProducts = "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.",
            InformationExports = "",
            InformationNewProduct = ""
        };

        internal List<NtpProject> ntpProjects;

        internal PredefinedNtpProjectList() 
        {
         ntpProjects = new ()
         {
             id1001, id1002
         };
        }
    }
}
