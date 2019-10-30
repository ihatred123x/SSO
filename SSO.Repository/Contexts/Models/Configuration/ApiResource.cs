using SSO.IRepository.Collections.Models.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ApiResource")]
    public class ApiResource: ModelBasePrimaryKey<int>, IApiResource
    {
        [Required]
        [DefaultValue(true)]
        public bool Enabled { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string DisplayName { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public Nullable<DateTime> Updated { get; set; }
        public Nullable<DateTime> LastAccessed { get; set; }
        [Required]
        public bool NonEditable { get; set; }
        public virtual ICollection<ApiClaim> ApiClaims { get; set; }
        public virtual ICollection<ApiProperty> ApiProperties { get; set; }
        public virtual ICollection<ApiScope> ApiScopes { get; set; }
        public virtual ICollection<ApiSecret> ApiSecrets { get; set; }
    }
}
