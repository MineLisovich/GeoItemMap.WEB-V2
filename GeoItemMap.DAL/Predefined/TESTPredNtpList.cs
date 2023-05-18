using GeoItemMap.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Predefined
{
    internal class TESTPredNtpList
    {
        internal List<NtpProject> ntpProjects;

        internal TESTPredNtpList()
        {
            int idCounter = 2000;
            float x = 55.53875618539466f, y = 27.750420691877412f;
            ntpProjects = new();
            for (int i = 0; i < 750; i++)
            {
                var item = new NtpProject()
                {
                    Id = idCounter,
                    X = x,
                    Y = y,
                    GeoType = GeoItemType.NtpProject,
                };

                ntpProjects.Add(item);

                idCounter++;
                x += 0.090000000000000f;
                y += 0.090000000000000f;


            }
        }
    }
}
