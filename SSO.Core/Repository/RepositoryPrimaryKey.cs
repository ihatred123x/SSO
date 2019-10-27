using SSO.Core.Contexts;
using SSO.Core.Contexts.Models;
using SSO.Core.Interface.Contexts.Models;
using SSO.Core.Interface.Repository;

namespace SSO.Core.Repository
{
    public abstract class RepositoryPrimaryKey<TID, TEntity>: RepositoryBase<TEntity>, IRepositoryPrimaryKey<TID, TEntity>
        where TID: struct
        where TEntity: ModelBasePrimaryKey<TID>, IModelPrimaryKey<TID>, new()
    {
        #region Constructor

        public RepositoryPrimaryKey(SSOIdentityServerContext ctx)
            : base(ctx)
        {

        }

        #endregion
    }
}
