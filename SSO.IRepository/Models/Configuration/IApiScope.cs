using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiScope: IModelPrimaryKey<int>
    {
        string Name { get; set; }

        string DisplayName { get; set; }
        string Description { get; set; }

        bool Required { get; set; }
        bool Emphasize { get; set; }
        bool ShowInDiscoveryDocument { get; set; }
        ICollection<IApiScopeClaim> ApiScopeClaims { get; set; }
    }
}
