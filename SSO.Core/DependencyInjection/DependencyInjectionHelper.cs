using IdentityServer4.Stores;
using Microsoft.Extensions.DependencyInjection;
using SSO.Core.Interface.Repository.Resource;
using SSO.Core.Repository.Resource;
using SSO.Core.Service.IdentityServer;

namespace SSO.Core.DependencyInjection
{
    public static class DependencyInjectionHelper
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IResourceStore, ResourceStoreService>();
        }

        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IApiResourceRepository, ApiResourceRepository>();
        }
    }
}
