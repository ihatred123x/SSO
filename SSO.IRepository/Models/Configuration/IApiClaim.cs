using SSO.IRepository.Collections.Models;

namespace SSO.IRepository.Models.Configuration
{
    public interface IApiClaim: IModelPrimaryKey<int>
    {
        string Type { get; set; }
    }
}
