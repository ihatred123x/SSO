﻿using System.Threading.Tasks;
using SSO.Core.Contexts;
using SSO.Core.Contexts.Models;
using SSO.Core.Interface.Contexts.Models;
using SSO.Core.Interface.Repository;

namespace SSO.Core.Repository
{
    public abstract class RepositoryPrimaryKey<TID, TIEntity, TEntity>: RepositoryBase<TIEntity, TEntity>, IRepositoryPrimaryKey<TID, TIEntity>
        where TID: struct
        where TIEntity: class, IModelPrimaryKey<TID>
        where TEntity: ModelBasePrimaryKey<TID>, TIEntity, new()
    {
        #region Constructor

        public RepositoryPrimaryKey(SSOIdentityServerContext ctx)
            : base(ctx)
        {

        }

        #endregion

        #region Public Methods

        public async Task<TIEntity> Update(TIEntity entity)
        {
            var _entity = await this.SSOContext.Set<TEntity>().FindAsync(entity.Id);

            if (_entity == null)
                throw new System.Exception($"Record not found. {typeof(TEntity).Name}");

            using (var tx = SSOContext.Database.BeginTransaction())
            {
                SSOContext.Update(entity);
                await SSOContext.SaveChangesAsync();
                await tx.CommitAsync();
            }

            return entity;
        }

        #endregion

        #region Override Members

        public async override Task Delete(TIEntity entity)
        {
            var _entity = await this.SSOContext.Set<TEntity>().FindAsync(entity.Id);

            if (_entity == null)
                throw new System.Exception($"Record not found. {typeof(TEntity).Name}");

            await base.Delete(entity);
        }

        #endregion
    }
}
