using SSO.IRepository.Collections.Models;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiProperty : IModelPrimaryKey<int>
    {
        string Key { get; set; }
        string Value { get; set; }
    }
}
