using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSO.IRepository.Models.Configuration
{
    public interface IIdentity: IModelPrimaryKey<int>
    {
        int IdentityResourceId { get; set; }
        IIdentityResource IdentityResource { get; set; }
    }
}
