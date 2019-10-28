using SSO.Core.Interface.Contexts.Models;
using System.Threading.Tasks;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryPrimaryKey<TID, TPKEntity>: IRepositoryRead<TPKEntity>, IRepositoryModify<TPKEntity>
        where TID: struct
        where TPKEntity : class, IModelPrimaryKey<TID>
    {
        Task<TPKEntity> Update(TPKEntity entity);
    }
}
