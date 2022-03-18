using BugTracker.Application.Contracts.Data;
using BugTracker.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Persistence.Services.Data
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : AuditableEntity
    {
        protected readonly ApplicationDbContext _dbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public virtual async Task UpdateAsync(T entity)
        {
            var oldEntity = await _dbContext.Set<T>().FindAsync(entity.Id);
            _dbContext.Entry(oldEntity).CurrentValues.SetValues(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<T> GetOnly()
        {
            return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync(int page, string searchString)
        {
            var toSkip = (page - 1) * 7;

            return await _dbContext.Set<T>()
                                    .OrderByDescending(t => t.CreatedDate)
                                    .Skip(toSkip)
                                    .Take(7)
                                    .ToListAsync();
        }
    }
}
