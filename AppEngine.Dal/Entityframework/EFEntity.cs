using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEngine.Dal.Entityframework
{
    public class EFEntity<TKey> : EntityBase<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override TKey Id
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
