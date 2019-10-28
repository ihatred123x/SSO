using SSO.Core.Interface.Contexts.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryRead<TIEntity>
        where TIEntity : class, IModel
    {
        Task<TIEntity> Get(Expression<Func<TIEntity, bool>> expression);
        Task<IEnumerable<TIEntity>> GetList();
        Task<IEnumerable<TIEntity>> GetList(Expression<Func<TIEntity, bool>> expression);
        Task<IEnumerable<TIEntity>> GetList(Expression<Func<TIEntity, bool>> expression, Expression<Func<TIEntity, object>>[] includes);
    }
}
