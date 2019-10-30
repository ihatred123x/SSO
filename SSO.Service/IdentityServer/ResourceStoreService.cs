using IdentityServer4.Models;
using IdentityServer4.Stores;
using SSO.IRepository.Collections.Resource;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SSO.Service.IdentityServer
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
        public Task<ApiResource> FindApiResourceAsync(string name)
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
