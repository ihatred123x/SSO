using IdentityServer4.Models;
using IdentityServer4.Stores;
using SSO.Core.Interface.Repository.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Core.Service.IdentityServer
{
    public class ResourceStoreService : IResourceStore
    {
        #region Constructor

        public ResourceStoreService(IApiResourceRepository apiResourceRepo)
        {
            this._apiResourceRepo = apiResourceRepo;
        }

        #endregion

        #region Public Methods
        public async Task<ApiResource> FindApiResourceAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            throw new NotImplementedException();
        }

        public Task<Resources> GetAllResourcesAsync()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Fields

        private readonly IApiResourceRepository _apiResourceRepo;

        #endregion
    }
}
