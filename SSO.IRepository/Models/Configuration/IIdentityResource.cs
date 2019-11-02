using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;

namespace SSO.IRepository.Models.Configuration
{
    public interface IIdentityResource: IModelPrimaryKey<int>
    {
        bool Enabled { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        bool Required { get; set; }
        bool Emphasize { get; set; }
        bool ShowInDiscoveryDocument { get; set; }
        DateTime Created { get; set; }
        Nullable<DateTime> Updated { get; set; }
        bool NonEditable { get; set; }

       ICollection<IIdentityClaim> IdentityClaims { get; set; }
    }
}
