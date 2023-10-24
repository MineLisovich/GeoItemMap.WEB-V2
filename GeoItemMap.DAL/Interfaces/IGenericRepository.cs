using GeoItemMap.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoItemMap.DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task <IEnumerable<TEntity>> GetAllCoordinates();
        TEntity FindById(int id);        
    }
}
