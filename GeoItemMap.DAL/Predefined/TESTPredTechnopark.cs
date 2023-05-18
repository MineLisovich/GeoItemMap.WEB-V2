using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class TESTPredTechnopark
    {
        internal List<Technopark> technoparks;

        internal TESTPredTechnopark()
        {
            int idCounter = 3000;  
            float x = 53.6047235337218f, y = 26.89027466942939f;
            technoparks = new();
            for (int i = 0; i < 750; i++)
            {
                var item = new Technopark()
                {
                    Id = idCounter,
                    X = x,
                    Y = y,
                    GeoType = GeoItemType.Technopark,
                };

                technoparks.Add(item);

                idCounter++;
                x += 0.090000000000000f;
                y += 0.090000000000000f;


            }
        }
    }
}
