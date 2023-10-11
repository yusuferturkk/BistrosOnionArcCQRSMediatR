using Bistros.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task CreateAsync(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null);
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
