using SSO.IRepository.Models.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public class ApiScopeClaim: ModelBasePrimaryKey<int>, IApiScopeClaim
    {
        [Required]
        [MaxLength(200)]
        public string Type { get; set; }
        
        [ForeignKey("ApiScope")]
        [Required]
        public int ApiScopeId { get; set; }
        public virtual IApiScope ApiScope { get; set; }

    }
}
