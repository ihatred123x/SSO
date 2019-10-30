using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("Client")]
    public class Client : ModelBasePrimaryKey<int>
    {

        [Required]
        [DefaultValue(true)]
        public bool Enabled { get; set; }
        [Required]
        [MaxLength(200)]
        public string ClientId { get; set; }
        [Required]
        [MaxLength(200)]
        public string ProtocolType { get; set; }
        [Required]
        public bool RequireClientSecret { get; set; }
        [MaxLength(200)]
        public string ClientName { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [MaxLength(2000)]
        public string ClientUri { get; set; }
        [MaxLength(2000)]
        public string LogoUri { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool RequireConsent { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AllowRememberConsent { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool RequirePkce { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AllowPlainTextPkce { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AllowAccessTokensViaBrowser { get; set; }
        [Required]
        [MaxLength(2000)]
        public string FrontChannelLogoutUri { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool FrontChannelLogoutSessionRequired { get; set; }
        [Required]
        [MaxLength(2000)]
        public string BackChannelLogoutUri { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool BackChannelLogoutSessionRequired { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool AllowOfflineAccess { get; set; }
        [Required]
        [DefaultValue(500)]
        public int IdentityTokenLifetime { get; set; }
        [Required]
        [DefaultValue(3600)]
        public int AccessTokenLifetime { get; set; }
        [Required]
        [DefaultValue(500)]
        public int AuthorizationCodeLifetime { get; set; }
        public Nullable<int> ConsentLifetime { get; set; }
        [Required]
        [DefaultValue(2592000)]
        public int AbsoluteRefreshTokenLifetime { get; set; }
        [Required]
        [DefaultValue(1296000)]
        public int SlidingRefreshTokenLifetime { get; set; }
        [Required]
        [DefaultValue(5)]
        public int RefreshTokenUsage { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        [Required]
        [DefaultValue(2592000)]
        public int RefreshTokenExpiration { get; set; }
        [Required]
        public int AccessTokenType { get; set; }
        [Required]
        [DefaultValue(true)]
        public int EnableLocalLogin { get; set; }
        [Required]
        [DefaultValue(true)]
        public int IncludeJwtId { get; set; }
        [Required]
        [DefaultValue(true)]
        public int AlwaysSendClientClaims { get; set; }
        [MaxLength(200)]
        public string ClientClaimsPrefix { get; set; }
        [MaxLength(200)]
        public string PairWiseSubjectSalt { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public Nullable<DateTime> Updated { get; set; }
        public Nullable<DateTime> LastAccessed { get; set; }
        public Nullable<int> UserSsoLifetime { get; set; }
        [MaxLength(200)]
        public string UserCodeType { get; set; }
        [Required]
        public int DeviceCodeLifetime { get; set; }
        [DefaultValue(false)]
        public bool NonEditable { get; set; }

        public virtual ICollection<ClientClaim> ClientClaims { get; set; }
        public virtual ICollection<ClientCorsOrigin> ClientCorsOrigins { get; set; }
        public virtual ICollection<ClientGrantType> ClientGrantTypes { get; set; }
        public virtual ICollection<ClientIdPRestriction> ClientIdPRestrictions { get; set; }
        public virtual ICollection<ClientPostLogoutRedirectUri> ClientPostLogoutRedirectUris { get; set; }
        public virtual ICollection<ClientProperty> ClientProperties { get; set; }
        public virtual ICollection<ClientRedirectUri> ClientRedirectUris { get; set; }
        public virtual ICollection<ClientScope> ClientScopes { get; set; }
        public virtual ICollection<ClientSecret> ClientSecrets { get; set; }

    }
}
