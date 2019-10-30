using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSO.Repository.Main;
using SSO.IService.IdentityServer;
using SSO.Service.IdentityServer;
using IdentityServer4.Stores;

namespace SSO.Service.Main
{
    public static class ServiceInjector
    {
        public static void AddService(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddRepository(configuration);
            // serviceCollection.AddScoped<IResourceStoreService, ResourceStoreService>();
            serviceCollection.AddTransient<IResourceStore, ResourceStoreService>();
            serviceCollection.AddTransient<IClientStore, ClientStoreService>();

        }

        public static IIdentityServerBuilder AddResource(this IIdentityServerBuilder identityServerBuilder)
        {
            identityServerBuilder.AddResourceStore<ResourceStoreService>();
            identityServerBuilder.AddClientStore<ClientStoreService>();

            return identityServerBuilder;
        }
    }
}
