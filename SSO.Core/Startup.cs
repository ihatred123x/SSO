using IdentityServer4.Stores;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SSO.Core.Contexts;
using SSO.Core.DependencyInjection;

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
            services.AddRepositories();
            services.AddServices();

            services.AddDbContext<SSOIdentityServerContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:SSODB"]));

            services.AddControllers();
            services.AddIdentityServer()
                .AddResourceStore<IResourceStore>()
                .AddDeveloperSigningCredential();
                
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
            using (var serviceScope =
   app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context =
                serviceScope.ServiceProvider.GetRequiredService<SSOIdentityServerContext>();
                context.Database.Migrate();
                context.Database.EnsureCreated();
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseIdentityServer();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
