using SSO.Core.Interface.Contexts.Models;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryPrimaryKey<TID, TPKEntity>: IRepository<TPKEntity>
        where TID: struct
        where TPKEntity : class, IModelPrimaryKey<TID> , new()
    {
    }
}
