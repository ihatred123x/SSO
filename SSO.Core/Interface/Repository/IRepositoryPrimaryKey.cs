using SSO.Core.Interface.Contexts.Models;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryPrimaryKey<TID, TPKEntity>: IRepositoryRead<TPKEntity>, IRepositoryModify<TPKEntity>
        where TID: struct
        where TPKEntity : class, IModelPrimaryKey<TID> , new()
    {
    }
}
