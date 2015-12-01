using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEngine.Dal
{
    public class EntityBase<TKey>
    {   
        public virtual TKey Id { get; set; }
    }
}
