using SSO.IRepository.Collections.Resource;
using SSO.IRepository.Models.Configuration;
using SSO.Repository.Contexts;
using SSO.Repository.Contexts.Models.Configuration;

namespace SSO.Repository.Collections.Resource
{
    public sealed class ApiResourceRepository : RepositoryPrimaryKey<int, IApiResource, ApiResource>, IApiResourceRepository
    {
        #region Constructor

        public ApiResourceRepository( SSOIdentityServerContext ctx)
            : base(ctx)
        {

        }

        #endregion
    }
}
