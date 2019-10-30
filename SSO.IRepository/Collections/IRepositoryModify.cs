using SSO.IRepository.Collections.Models;
using System.Threading.Tasks;

namespace SSO.IRepository.Collections
{
    public interface IRepositoryModify<TEntity>
        where TEntity : class, IModel
    {
        Task<TEntity> Create(TEntity entity);
        Task Delete(TEntity entity);
    }
}
