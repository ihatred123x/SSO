using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSO.IRepository.Collections.Resource;
using SSO.Repository.Collections.Resource;

namespace SSO.Repository.Main
{
    public static class RepositoryInjector 
    {
        public static void AddRepository(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<SSO.Repository.Contexts.SSOIdentityServerContext>(
                opts => opts.UseSqlServer(configuration["ConnectionString:SSODB"], o => o.MigrationsAssembly("SSO.Repository")));

            serviceCollection.AddScoped<IApiResourceRepository, ApiResourceRepository>();
            serviceCollection.AddScoped<IIdentityResourceRepository, IdentityResourceRepository>();
        }
    }
}
