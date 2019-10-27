using SSO.Core.Interface.Contexts.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryRead<TEntity>
        where TEntity : class, IModel, new()
    {
        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> GetList();
        Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression);
        Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes);
    }
}
