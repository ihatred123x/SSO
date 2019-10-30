using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public class ApiScopeClaim: ModelBasePrimaryKey<int>
    {
        [Required]
        [MaxLength(200)]
        public string Type { get; set; }
        
        [ForeignKey("ApiScope")]
        [Required]
        public int ApiScopeId { get; set; }
        public virtual ApiScope ApiScope { get; set; }

    }
}
