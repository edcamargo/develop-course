using webadmin.Domain.Core.Interfaces.Repositories;
using webadmin.Domain.Core.Interfaces.Services;

namespace webadmin.Domain.Service.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public Task AddRangeAsync(TEntity entity)
        {
            return _repositoryBase.AddRangeAsync(entity);
        }
        public Task DeleteAsync(TEntity entity)
        {
            return _repositoryBase.DeleteAsync(entity);
        }
        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _repositoryBase.GetAllAsync();
        }
        public Task<TEntity?> GetByIdAsync(int id)
        {
            return _repositoryBase.GetByIdAsync(id);
        }
        public Task UpdateAsync(TEntity entity)
        {
            return _repositoryBase.UpdateAsync(entity);
        }        
    }
}
