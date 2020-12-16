using Caixa.Business.Interfaces;
using Caixa.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Caixa.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly ApplicationContext ApplicationContext;

        public Repository(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }

        public async Task<TEntity> Get(Guid id)
        {
            return await ApplicationContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await ApplicationContext.Set<TEntity>().ToListAsync();
        }

        public void Save(TEntity entity)
        {
            ApplicationContext.Set<TEntity>().Add(entity);
            ApplicationContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            ApplicationContext.Set<TEntity>().Update(entity);
            ApplicationContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = ApplicationContext.Set<TEntity>().Find(id);
            ApplicationContext.Set<TEntity>().Remove(entity);
            ApplicationContext.SaveChanges();
        }

        public void Dispose()
        {
            ApplicationContext.Dispose();
        }
    }
}
