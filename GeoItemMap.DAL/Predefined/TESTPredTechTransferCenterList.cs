using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class TESTPredTechTransferCenterList
    {
        internal List<TechTransferCenter> techTransferCenters;

        internal TESTPredTechTransferCenterList()
        {
            int idCounter = 4000;
            float x = 55.54611705292226f, y = 30.42186506338951f;
            techTransferCenters = new();
            for (int i = 0; i < 750; i++)
            {
                var item = new TechTransferCenter()
                {
                    Id = idCounter,
                    X = x,
                    Y = y,
                    GeoType = GeoItemType.TechTransferCenter,
                };

                techTransferCenters.Add(item);

                idCounter++;
                x += 0.090000000000000f;
                y += 0.090000000000000f;

            }
        }
    }
}
