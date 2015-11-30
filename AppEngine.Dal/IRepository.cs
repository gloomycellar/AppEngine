using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AppEngine.Dal
{
    public interface IRepository<T, TKey> where T : EntityBase<TKey>
    {
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null);

        Task Insert(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}