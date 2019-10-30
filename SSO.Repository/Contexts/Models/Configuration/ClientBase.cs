using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public  abstract class ClientBase: ModelBasePrimaryKey<int>
    {
        [Required]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
