using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class TESTPredInnProject
    {
        internal List<InnProject> innProjects;
        internal TESTPredInnProject()
        { 
            int idCounter = 1;
            float x = 53.258751482993326f, y = 26.654139552380126f;
            innProjects = new();
            for (int i = 0; i < 750; i++)
            {
                var item = new InnProject()
                {
                    Id = idCounter,
                    X = x,
                    Y = y,
                    GeoType = GeoItemType.InnProject,
                };

                innProjects.Add(item);

                idCounter++;
                x += 0.090000000000000f;
                y += 0.090000000000000f;


            }
        }
    }
}
