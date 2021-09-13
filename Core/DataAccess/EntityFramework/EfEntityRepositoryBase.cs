using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IRepository<TEntity>
       where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        public void Add(TEntity par)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(par);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity par)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(par);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity par)
        {
            using (TContext context = new TContext())
            {
                var updated = context.Entry(par);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
