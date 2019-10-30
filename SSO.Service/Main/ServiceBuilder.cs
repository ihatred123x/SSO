using Microsoft.AspNetCore.Builder;
using SSO.Repository.Main;

namespace SSO.Service.Main
{
    public static class ServiceBuilder
    {
        public static void BuildService(this IApplicationBuilder app)
        {
            app.BuildRepository();
        }
    }
}
