using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AppEngine.Dal.MongoDB
{
    class MongoRepository<T> : AbstractRepository<T, string>
        where T : EntityBase<string>
    {
        private MongoDatabaseBase database;
        private MongoCollectionBase<T> collection;

        public override Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public override Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public override Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public override Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            throw new NotImplementedException();
        }

        protected override Task Commit()
        {
            throw new NotImplementedException();
        }
    }
}
