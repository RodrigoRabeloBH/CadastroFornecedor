using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevIO.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .Where(predicate)
                .ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {

            return await _context.Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await SaveChanges();
        }

        public virtual async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await SaveChanges();
        }

        public virtual async Task Edit(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await SaveChanges();
        }

        public virtual async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public virtual void Dispose()
        {
            _context?.Dispose();
        }
    }
}