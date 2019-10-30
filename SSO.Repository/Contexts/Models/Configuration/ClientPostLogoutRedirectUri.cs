using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientPostLogoutRedirectUri")]
    public class ClientPostLogoutRedirectUri: ClientBase
    {
        [Required]
        [MaxLength(2000)]
        public string PostLogoutRedirectUri { get; set; }
    }
}
