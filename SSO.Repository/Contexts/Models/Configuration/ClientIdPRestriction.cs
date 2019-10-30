using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientIdPRestriction")]
    public class ClientIdPRestriction: ClientBase
    {
        [Required]
        [MaxLength(200)]
        public string Provider { get; set; }
    }
}
