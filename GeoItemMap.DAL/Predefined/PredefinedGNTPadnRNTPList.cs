using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class PredefinedGNTPadnRNTPList
    {
        NtpProject id1001 = new()
        {

         
            Id = 1001,
            X =  55.53875618539466f,
            Y = 27.750420691877412f,
            GeoType = GeoItemType.NtpProject,
            NameProgramm = "БПТ_14",
            StateCustomer = "",
            ParentImplemOrg = "ОАО «Витязь»",
            ImplemOrg = "ОАО «Витязь»",
            CountryImplemOrg = "Республика Беларусь",
            AreaImplemOrg = "Витебская область",
            CityImplemOrg = "г. Витебск",
            NameTask = "«Разработать и освоить в серийном производстве стационарную электрозарядную станцию постоянного тока для легковых электромобилей»",
            StateTask = "",
            Thelevelstructure = "V технологический уклад",
            NameNewDevProducts = "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.",
            InformationExports = "",
            InformationNewProduct = ""
        };

        NtpProject id1002 = new()
        {
            Id = 1002,
            X = 53.07712887150114f,
            Y = 26.669676564796656f,
            GeoType = GeoItemType.NtpProject,
            NameProgramm = "БПТ_14",
            StateCustomer = "",
            ParentImplemOrg = "ОАО «Витязь»",
            ImplemOrg = "ОАО «Витязь»",
            CountryImplemOrg = "Республика Беларусь",
            AreaImplemOrg = "Витебская область",
            CityImplemOrg = "г. Витебск",
            NameTask = "«Разработать и освоить в серийном производстве стационарную электрозарядную станцию постоянного тока для легковых электромобилей»",
            StateTask = "",
            Thelevelstructure = "V технологический уклад",
            NameNewDevProducts = "Станция электрозарядная стационарная Витязь ЕС-401,EC-401-10, шт.",
            InformationExports = "",
            InformationNewProduct = ""
        };

        internal List<NtpProject> gNTPandRNTPs;

        internal PredefinedGNTPadnRNTPList() 
        { 
         gNTPandRNTPs = new ()
         {
             id1001, id1002
         };
        }
    }
}
