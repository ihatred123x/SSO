using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SSO.IService.IdentityServer;
using SSO.Service.Main;
using System.Collections.Generic;
using static IdentityModel.OidcConstants;

namespace SSO.Core
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddService(this.Configuration);
            services.AddControllers();
            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddResource();
                //.AddInMemoryClients(new List<IdentityServer4.EntityFramework.Entities.Client> {
                //new IdentityServer4.EntityFramework.Entities.Client
                //{
                //    ClientId = "client",
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    ClientSecrets = { new IdentityServer4.EntityFramework.Entities.Secret("secret".Sha256()) },
                //    AllowedScopes = { "api1" } }
                //})
                
                //.AddInMemoryApiResources(new List<ApiResource>
                //{
                //    new ApiResource("api1", "My API")
                //})
                //.AddInMemoryClients(new List<Client> {
                //new Client
                //{ 
                //    ClientId = "client",
                //    AllowedGrantTypes = GrantTypes.ClientCredentials,
                //    ClientSecrets = { new Secret("secret".Sha256()) },
                //    AllowedScopes = { "api1" } }
                //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseIdentityServer();

            app.BuildService();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
