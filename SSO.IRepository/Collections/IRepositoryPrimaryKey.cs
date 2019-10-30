using SSO.IRepository.Collections.Models;
using System.Threading.Tasks;

namespace SSO.IRepository.Collections
{
    public interface IRepositoryPrimaryKey<TID, TPKEntity>: IRepositoryRead<TPKEntity>, IRepositoryModify<TPKEntity>
        where TID: struct
        where TPKEntity : class, IModelPrimaryKey<TID>
    {
        Task<TPKEntity> Update(TPKEntity entity);
    }
}
