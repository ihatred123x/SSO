﻿using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiResource : IModelPrimaryKey<int>
    {
        bool Enabled { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        DateTime Created { get; set; }
        Nullable<DateTime> Updated { get; set; }
        Nullable<DateTime> LastAccessed { get; set; }
        bool NonEditable { get; set; }
        ICollection<IApiClaim> ApiClaims { get; set; }
        ICollection<IApiProperty> ApiProperties { get; set; }
        ICollection<IApiScope> ApiScopes { get; set; }
        ICollection<IApiSecret> ApiSecrets { get; set; }
    }
}
