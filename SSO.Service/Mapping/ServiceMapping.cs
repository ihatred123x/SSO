using AutoMapper;
using SSO.Repository.Contexts.Models.Configuration;

namespace SSO.Service.Mapping
{
    public sealed class ServiceMapping : Profile
    {
        public ServiceMapping()
        {
            CreateMap<ApiSecret, IdentityServer4.Models.Secret>();
            CreateMap<ApiResource, IdentityServer4.Models.ApiResource>();
            CreateMap<IdentityResource, IdentityServer4.Models.IdentityResource>();
        }
    }
}
