using Microsoft.EntityFrameworkCore;
using webadmin.Domain.Core.Interfaces.Repositories;

namespace webadmin.InfraStructure.Data.Repositories
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        public async Task<TEntity?> GetByIdAsync(object id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        public async Task AddRangeAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddRangeAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public void Dispose() => _context.Dispose();
    }
}
