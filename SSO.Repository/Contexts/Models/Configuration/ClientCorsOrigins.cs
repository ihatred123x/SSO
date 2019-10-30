using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientCorsOrigin")]
    public class ClientCorsOrigin: ClientBase
    {
        [Required]
        [MaxLength(150)]
        public string Origin { get; set; }
    }
}
