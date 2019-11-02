using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiScopeClaim: IModelPrimaryKey<int>
    {
        string Type { get; set; }
        IApiScope ApiScope { get; set; }
    }
}
