using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public abstract class IdentityBase : ModelBasePrimaryKey<int>
    {
        [Required]
        [ForeignKey("IdentityResource")]
        public int IdentityResourceId { get; set; }
        public virtual IdentityResource IdentityResource { get; set; }
    }
}
