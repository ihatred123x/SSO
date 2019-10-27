using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Core.Contexts.Models.Configuration
{
    [Table("ClientGrantType")]
    public class ClientGrantType: ClientBase
    {
        [Required]
        [MaxLength(250)]
        public string GrantType { get; set; }
    }
}
