namespace SSO.IRepository.Collections.Models
{
    public interface IModelPrimaryKey<TID>: IModel
        where TID: struct
    {
        TID Id { get; set; }
    }
}
