using AppEngine.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal
{
    public abstract class Repository<T, TKey> : IRepository<T, TKey>, IDisposable
        where T : EntityBase<TKey>
    {
        public abstract Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null);

        public abstract Task Delete(T entity);

        public abstract Task Insert(T entity);

        public abstract Task Update(T entity);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected abstract void Dispose(bool disposing);

        protected abstract Task Commit();
    }
}
