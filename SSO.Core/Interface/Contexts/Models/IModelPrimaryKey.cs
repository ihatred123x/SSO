using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Core.Interface.Contexts.Models
{
    public interface IModelPrimaryKey<TID>: IModel
        where TID: struct
    {
        TID Id { get; set; }
    }
}
