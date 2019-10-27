using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Core.Contexts.Models.Configuration
{
    [Table("ApiScope")]
    public class ApiScope : ApiResourceBase
    {
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

        [MaxLength(200)]
        public string DisplayName { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Required { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool Emphasize { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool ShowInDiscoveryDocument { get; set; }
        public virtual ICollection<ApiScopeClaim> ApiScopeClaims { get; set; }
    }
}
