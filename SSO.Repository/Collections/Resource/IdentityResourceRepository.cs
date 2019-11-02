using System.Threading.Tasks;
using SSO.IRepository.Collections.Resource;
using SSO.IRepository.Models.Configuration;
using SSO.Repository.Contexts;
using SSO.Repository.Contexts.Models.Configuration;

namespace SSO.Repository.Collections.Resource
{
    class IdentityResourceRepository: RepositoryPrimaryKey<int, IIdentityResource, IdentityResource>, IIdentityResourceRepository
    {
        #region Constructor

        public IdentityResourceRepository(SSOIdentityServerContext SSOContext) 
            : base(SSOContext)
        {

        }


        #endregion
    }
}
