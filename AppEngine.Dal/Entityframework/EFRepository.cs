using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal.Entityframework
{
    public class EFRepository<T, TKey> : AbstractRepository<T, TKey>
        where T : EntityBase<TKey>
    {
        protected bool disposed = false;

        private DbContext context;
        private DbSet<T> dbSet;

        public EFRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public override async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = dbSet;

            if (null != predicate)
            {
                query = query.Where(predicate);
            }

            return await query.ToListAsync();
        }

        public override async Task Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            await Commit();
        }

        public override async Task Insert(T entity)
        {
            dbSet.Add(entity);
            await Commit();
        }

        public override async Task Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await Commit();
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        protected override async Task Commit()
        {
            await context.SaveChangesAsync();
        }
    }
}
