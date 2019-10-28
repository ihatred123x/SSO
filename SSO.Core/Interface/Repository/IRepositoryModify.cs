using SSO.Core.Interface.Contexts.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.Core.Interface.Repository
{
    public interface IRepositoryModify<TEntity>
        where TEntity : class, IModel
    {
        Task<TEntity> Create(TEntity entity);
        Task Delete(TEntity entity);
    }
}
