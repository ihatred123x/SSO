using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public abstract class ApiResourceBase: ModelBasePrimaryKey<int>
    {
        [ForeignKey("ApiResource")]
        public int ApiResourceId { get; set; }
        public virtual ApiResource ApiResource { get; set; }
    }
}
