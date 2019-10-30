
using Microsoft.EntityFrameworkCore;
using SSO.Repository.Contexts.Models.Configuration;
using SSO.Repository.Contexts.Models.Persistent;
using System;

namespace SSO.Repository.Contexts
{
    public class SSOIdentityServerContext : DbContext

    {
        public SSOIdentityServerContext(DbContextOptions options)
            : base(options)
        {

        }

        #region Configuration

        #region Identity Resource
        public virtual DbSet<IdentityResource> IdentityResources { get; set; }
        public virtual DbSet<IdentityClaim> IdentityClaims { get; set; }

        #endregion

        #region Api Resource
        public virtual DbSet<ApiResource> ApiResources { get; set; }
        public virtual DbSet<ApiClaim> ApiClaims { get; set; }
        public virtual DbSet<ApiProperty> ApiProperties { get; set; }
        public virtual DbSet<ApiScope> ApiScopes { get; set; }
        public virtual DbSet<ApiSecret> ApiSecrets { get; set; }
        public virtual DbSet<ApiScopeClaim> ApiScopeClaims { get; set; }
        #endregion

        #region Client
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientClaim> ClientClaims { get; set; }
        public virtual DbSet<ClientCorsOrigin> ClientCorsOrigins { get; set; }
        public virtual DbSet<ClientIdPRestriction> ClientIdPRestrictions { get; set; }
        public virtual DbSet<ClientPostLogoutRedirectUri> ClientPostLogoutRedirectUris { get; set; }
        public virtual DbSet<ClientProperty> ClientProperties { get; set; }
        public virtual DbSet<ClientRedirectUri> ClientRedirectUris { get; set; }
        public virtual DbSet<ClientScope> ClientScopes { get; set; }
        public virtual DbSet<ClientSecret> ClientSecrets { get; set; }
        #endregion

        #endregion

        #region Persistent
        public virtual DbSet<DeviceCode> DeviceCodes { get; set; }
        public virtual DbSet<PersistentGrant> PersistentGrants { get; set; }

        #endregion


        #region Override Members

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApiResource>()
                .HasIndex(ar => ar.Name)
                .IsUnique();

            modelBuilder.Entity<ApiScope>()
                .HasIndex(a => a.Name)
                .IsUnique();

            modelBuilder.Entity<IdentityResource>()
                .HasIndex(ir => ir.Name)
                .IsUnique();

            modelBuilder.Entity<PersistentGrant>()
                .HasIndex(pg => new { pg.SubjectId, pg.ClientId, pg.Type })
                .IsUnique();

            modelBuilder.Entity<IdentityResource>()
                .HasData(new IdentityResource
                {
                    Id = 1,
                    Name = "sso-user",
                    Enabled = true,
                    DisplayName = "sso user",
                    ShowInDiscoveryDocument = true,
                    Created = DateTime.Now,
                    NonEditable = true
                });

            modelBuilder.Entity<IdentityClaim>()
                .HasData(new IdentityClaim
                {
                    Id = 1,
                    IdentityResourceId  = 1,
                    Value = "full-access"
                });
        }
        #endregion
    }
}
