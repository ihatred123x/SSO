using SSO.Core.Contexts;
using SSO.Core.Contexts.Models.Configuration;
using SSO.Core.Interface.Contexts.Models.Configuration;
using SSO.Core.Interface.Repository.Resource;

namespace SSO.Core.Repository.Resource
{
    public sealed class ApiResourceRepository: RepositoryPrimaryKey<int, IApiResource, ApiResource>, IApiResourceRepository
    {
        #region Constructor

        public ApiResourceRepository( SSOIdentityServerContext ctx)
            : base(ctx)
        {

        }

        #endregion
    }
}
