using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SSO.Repository.Contexts;

namespace SSO.Repository.Main
{
    public static class RepositoryBuilder
    {
        public static void BuildRepository(this IApplicationBuilder app)
        {
            using (IServiceScope serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context =
                serviceScope.ServiceProvider.GetRequiredService<SSOIdentityServerContext>();
                context.Database.EnsureCreated();
            }
        }
    }
}
