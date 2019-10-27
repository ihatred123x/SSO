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
            this._ctx = ctx;
        }

        #endregion

        #region Implemented Members
        public virtual async Task Delete(TEntity entity)
        {
            using (var tx = _ctx.Database.BeginTransaction())
            {
                this._ctx.Remove(entity);
                await this._ctx.SaveChangesAsync();
                await tx.CommitAsync();
            }
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return await this._ctx.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<IEnumerable<TEntity>> GetList()
        {
            return await this._ctx.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return await this._ctx.Set<TEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> expression, Expression<Func<TEntity, object>>[] includes)
        {
            var _query = this._ctx.Set<TEntity>().Where(expression).AsQueryable();

            foreach (var item in includes)
                _query.Include(item);

            return await _query.ToListAsync();
        }

        public virtual async Task<TEntity> Create(TEntity entity)
        {
            using (var tx = _ctx.Database.BeginTransaction())
            {
                this._ctx.Add(entity);
                await this._ctx.SaveChangesAsync();
                await tx.CommitAsync();
            }

            return entity;
        }

        #endregion

        #region Protected Properties

        protected SSOIdentityServerContext DbContext { get => this._ctx; }

        #endregion

        #region Private Fields

        private readonly SSOIdentityServerContext _ctx;

        #endregion
    }
}
