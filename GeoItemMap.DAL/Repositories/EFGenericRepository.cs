using GeoItemMap.DAL.DataContext;
using GeoItemMap.DAL.Entities;
using GeoItemMap.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace GeoItemMap.DAL.Repositories
{
    public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private AppDbContext _dbContext;
        private DbSet <TEntity> _dbSet;

        public EFGenericRepository (AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }  
        
        public async Task <IEnumerable<TEntity>> GetAllCoordinates()
        {
            return await _dbSet.ToListAsync();

        }
        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
