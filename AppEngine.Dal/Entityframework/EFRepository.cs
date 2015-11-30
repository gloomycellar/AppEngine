using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal.Entityframework
{
    public class EFRepository<T> : AbstractRepository<T> 
        where T : class
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public EFRepository(DbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public override IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            if (null != predicate)
            {
                return dbSet.Where(predicate).ToList();
            }
            else
            {
                return dbSet.ToList();
            }
        }

        public override void Delete(T entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
            Commit();
        }

        public override void Save(T entity)
        {
            dbSet.Add(entity);
            Commit();
        }

        public override void Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            Commit();
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

        protected override void Commit()
        {
            context.SaveChanges();
        }
    }
}
