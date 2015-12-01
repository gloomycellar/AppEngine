using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using AppEngine.Dal.Mongo;

namespace AppEngine.Dal.MongoDB
{
    class MongoRepository<T> : Repository<T, ObjectId>
        where T : MongoEntity
    {
        private MongoDatabaseBase database;
        private MongoCollectionBase<T> collection;

        public override Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public override async Task Delete(T entity)
        {
            await collection.DeleteOneAsync(x => x.Id == entity.Id);
        }

        public override async Task Insert(T entity)
        {
            await collection.InsertOneAsync(entity);
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
