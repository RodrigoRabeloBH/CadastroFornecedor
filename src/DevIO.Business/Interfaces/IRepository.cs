using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task Edit(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}