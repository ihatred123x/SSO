using SSO.IRepository.Collections.Models;
using System;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiSecret: IModelPrimaryKey<int>
    {
        string Description { get; set; }
        string Value { get; set; }
        Nullable<DateTime> Expiration { get; set; }
        string Type { get; set; }
        DateTime Created { get; set; }
    }
}
