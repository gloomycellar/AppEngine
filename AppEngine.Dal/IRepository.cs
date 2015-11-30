using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AppEngine.Dal
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null);

        void Save(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}