using Microsoft.EntityFrameworkCore;
using SSO.Core.Contexts;
using SSO.Core.Contexts.Models;
using SSO.Core.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.Core.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryRead<TEntity>, IRepositoryModify<TEntity>
        where TEntity: ModelBase, new()
    {
        #region Constructor

        public RepositoryBase(SSOIdentityServerContext ctx)
        {
            this.SSOContext = ctx;
        }

        #endregion

        #region Implemented Members
        public virtual async Task Delete(TEntity entity)
        {
            using (var tx = SSOContext.Database.BeginTransaction())
            {
                this.SSOContext.Remove(entity);
                await this.SSOContext.SaveChangesAsync();
                await tx.CommitAsync();
            }
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return await this.SSOContext.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<IEnumerable<TEntity>> GetList()
        {
            return await this.SSOContext.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return await this.SSOContext.Set<TEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            var _query = this.SSOContext.Set<TEntity>().Where(expression).AsQueryable();

            foreach (var item in includes)
                _query.Include(item);

            return await _query.ToListAsync();
        }

        public virtual async Task<TEntity> Create(TEntity entity)
        {
            using (var tx = SSOContext.Database.BeginTransaction())
            {
                this.SSOContext.Add(entity);
                await this.SSOContext.SaveChangesAsync();
                await tx.CommitAsync();
            }

            return entity;
        }

        #endregion

        #region Protected Properties

        protected SSOIdentityServerContext SSOContext { get; private set; }

        #endregion
    }
}
