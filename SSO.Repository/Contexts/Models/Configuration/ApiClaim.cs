using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ApiClaim")]
    public class ApiClaim: ApiResourceBase
    {
        [MaxLength(200)]
        [Required]
        public string Type { get; set; }

    }
}
