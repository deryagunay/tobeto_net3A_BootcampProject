using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>
        where TEntity : BaseEntity<TEntityId>
        where TContext : DbContext
    {
        public Task<TEntity> Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Query()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
