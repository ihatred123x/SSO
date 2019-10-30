using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("IdentityResource")]
    public class IdentityResource : ModelBasePrimaryKey<int>
    {
        [Required]
        [DefaultValue(true)]
        public bool Enabled { get; set; }
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string DisplayName { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        [DefaultValue(false)]
        [Required]
        public bool Required { get; set; }
        [DefaultValue(false)]
        [Required]
        public bool Emphasize { get; set; }
        [DefaultValue(false)]
        [Required]
        public bool ShowInDiscoveryDocument { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public Nullable<DateTime> Updated { get; set; }
        [DefaultValue(false)]
        public bool NonEditable { get; set; }

        public ICollection<IdentityClaim> IdentityClaims { get; set; }
    }
}
