namespace SSO.IRepository.Models.Configuration
{
    public interface IIdentityClaim: IIdentity
    {
        string Value { get; set; }
    }
}
