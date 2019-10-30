using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SSO.Repository.Contexts
{
    public class SSOIdentityServerContxtFactory : IDesignTimeDbContextFactory<SSOIdentityServerContext>
    {
        public SSOIdentityServerContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true)
               .Build();
            var optionsBuilder = new DbContextOptionsBuilder<SSOIdentityServerContext>();
            optionsBuilder.UseSqlServer(config["ConnectionString:SSODB"]);

            var context = new SSOIdentityServerContext(optionsBuilder.Options);
            context.Database.EnsureCreated();
            return context;
        }

    }
}
