using SSO.IRepository.Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.IRepository.Collections
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
