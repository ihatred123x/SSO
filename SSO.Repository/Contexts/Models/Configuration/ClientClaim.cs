using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientClaim")]
    public class ClientClaim: ClientBase
    {
        [Required]
        [MaxLength(250)]
        public string Type { get; set; }

        [Required]
        [MaxLength(250)]
        public string Value { get; set; }
    }
}
