using AppEngine.Dal;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal.Mongo
{
    public class MongoEntity : EntityBase<ObjectId>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public override ObjectId Id
        {
            get
            {
                return base.Id;
            }

            set
            {
                base.Id = value;
            }
        }
    }
}
