using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("IdentityClaim")]
    public class IdentityClaim: IdentityBase
    {
        [Required]
        [MaxLength(2000)]
        public string Value { get; set; }
    }
}
