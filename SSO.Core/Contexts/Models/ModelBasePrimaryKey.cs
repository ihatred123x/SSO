using SSO.Core.Interface.Contexts.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Core.Contexts.Models
{
    public abstract class ModelBasePrimaryKey<TID>: ModelBase, IModelPrimaryKey<TID>
        where TID: struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TID Id { get; set; }
    }
}
