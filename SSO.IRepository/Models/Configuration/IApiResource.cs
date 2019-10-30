using System;

namespace SSO.IRepository.Collections.Models.Configuration
{
    public interface IApiResource: IModelPrimaryKey<int>
    {
        bool Enabled { get; set; }
        string Name { get; set; }
        string DisplayName { get; set; }
        string Description { get; set; }
        DateTime Created { get; set; }
        Nullable<DateTime> Updated { get; set; }
        Nullable<DateTime> LastAccessed { get; set; }
        bool NonEditable { get; set; }
    }
}
