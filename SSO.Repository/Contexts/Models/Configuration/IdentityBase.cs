using SSO.IRepository.Models.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public abstract class IdentityBase : ModelBasePrimaryKey<int>, IIdentity
    {
        [Required]
        [ForeignKey("IdentityResource")]
        public int IdentityResourceId { get; set; }
        public virtual IIdentityResource IdentityResource { get; set; }
    }
}
