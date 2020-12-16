using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Caixa.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(Guid id);
    }
}
