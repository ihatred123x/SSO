using SSO.IRepository.Collections.Models;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.IRepository.Collections
{
    public interface IRepositoryRead<TIEntity>
        where TIEntity : class, IModel
    {
        Task<TIEntity> Get(Expression<Func<TIEntity, bool>> expression);
        IQueryable<TIEntity> GetList();
        IQueryable<TIEntity> GetList(Expression<Func<TIEntity, bool>> expression);
        IQueryable<TIEntity> GetList(Expression<Func<TIEntity, bool>> expression, Expression<Func<TIEntity, object>>[] includes);
    }
}
