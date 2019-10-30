using Microsoft.EntityFrameworkCore;
using SSO.IRepository.Collections;
using SSO.IRepository.Collections.Models;
using SSO.Repository.Contexts;
using SSO.Repository.Contexts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SSO.Repository.Collections
{
    public abstract class RepositoryBase<TIEntity, TEntity> :  IRepositoryRead<TIEntity>, IRepositoryModify<TIEntity>
        where TIEntity: class, IModel
        where TEntity: ModelBase, TIEntity, new()
    {
        #region Constructor

        public RepositoryBase(SSOIdentityServerContext ctx)
        {
            this.SSOContext = ctx;
        }

        #endregion

        #region Implemented Members
        public virtual async Task Delete(TIEntity entity)
        {
            using (var tx = SSOContext.Database.BeginTransaction())
            {
                this.SSOContext.Remove(entity);
                await this.SSOContext.SaveChangesAsync();
                await tx.CommitAsync();
            }
        }

        public virtual async Task<TIEntity> Get(Expression<Func<TIEntity, bool>> expression)
        {
            return await this.SSOContext.Set<TIEntity>().FirstOrDefaultAsync(expression);
        }

        public virtual async Task<IEnumerable<TIEntity>> GetList()
        {
            return await this.SSOContext.Set<TIEntity>().ToListAsync();
        }

        public virtual async Task<IEnumerable<TIEntity>> GetList(Expression<Func<TIEntity, bool>> expression)
        {
            return await this.SSOContext.Set<TIEntity>().Where(expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<TIEntity>> GetList(Expression<Func<TIEntity, bool>> expression, Expression<Func<TIEntity, object>>[] includes)
        {
            var _query = this.SSOContext.Set<TIEntity>().Where(expression).AsQueryable();

            foreach (var item in includes)
                _query.Include(item);

            return await _query.ToListAsync();
        }

        public virtual async Task<TIEntity> Create(TIEntity entity)
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
