using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal.MongoDB
{
    class MongoRepository<T> : AbstractRepository<T>
        where T : class
    {
        public override void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public override void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public override void Update(T entity)
        {
            throw new NotImplementedException();
        }

        protected override void Commit()
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
