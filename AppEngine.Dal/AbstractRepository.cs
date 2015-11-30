using AppEngine.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal
{
    public abstract class AbstractRepository<T> : IRepository<T>, IDisposable
        where T : class
    {
        protected bool disposed = false;

        public abstract IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null);

        public abstract void Delete(T entity);

        public abstract void Save(T entity);

        public abstract void Update(T entity);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract void Dispose(bool disposing);

        protected abstract void Commit();
    }
}
