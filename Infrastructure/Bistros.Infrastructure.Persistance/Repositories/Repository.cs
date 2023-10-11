using Bistros.Core.Application.Interfaces;
using Bistros.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Infrastructure.Persistance.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            var value = await _dbSet.ToListAsync();
            return value;
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            var value = await _dbSet.Where(predicate).ToListAsync();
            return value;
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> queryable = _dbSet;
            return includeProperties.Aggregate(queryable, (current, includeProperty) => current.Include(includeProperty));
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var value = await _dbSet.FindAsync(id);
            return value;
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
