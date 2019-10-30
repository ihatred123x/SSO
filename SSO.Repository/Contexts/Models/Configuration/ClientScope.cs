using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientScope")]
    public class ClientScope: ClientBase
    {
        [Required]
        [MaxLength(200)]
        public string Scope { get; set; }
    }
}
