using AutoMapper;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using SSO.IRepository.Collections.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Service.IdentityServer
{
    class ResourceStoreService : ServiceBase, IResourceStore
    {
        #region Constructor

        public ResourceStoreService(
            IApiResourceRepository apiResourceRepository,
            IIdentityResourceRepository identityResourceRepository,
            IMapper mapper)
            : base(mapper)
        {
            this._apiResourceRepository = apiResourceRepository;
            this._identityResourceRepository = identityResourceRepository;
        }

        #endregion

        #region Public Methods
        public async Task<ApiResource> FindApiResourceAsync(string name)
        {
            var _apiResource = await this._apiResourceRepository.Get(entity => entity.Name.Equals(name));

            return this.Mapper.Map<ApiResource>(_apiResource);
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            var _resources = this._apiResourceRepository.GetList(entity => entity.ApiScopes.Any(o => scopeNames.Contains(o.Name)));

            return await Task.Run(() =>
            {
                return this.Mapper.Map<IEnumerable<ApiResource>>(_resources);
            });
        }

        public async Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            var _identityResources = this.Mapper.Map<IEnumerable<IdentityResource>>(this._identityResourceRepository.GetList());

            return await Task.Run(() =>
            {
                return _identityResources;
            });
        }

        public async Task<Resources> GetAllResourcesAsync()
        {
            var _apiResources = this.Mapper.Map<IEnumerable<ApiResource>>(this._apiResourceRepository.GetList());
            var _identityResources = this.Mapper.Map<IEnumerable<IdentityResource>>(this._identityResourceRepository.GetList()); 

            return await Task.Run(() =>
            {
                var _resources = new Resources(_identityResources, _apiResources);
                return _resources;
            });
        }

        #endregion

        #region Private Fields

        private readonly IApiResourceRepository _apiResourceRepository;
        private readonly IIdentityResourceRepository _identityResourceRepository;

        #endregion
    }
}
