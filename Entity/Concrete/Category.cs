
using Entity.Common;
using System.Collections.Generic;

namespace Entity.Concrete
{
    public class Category : BaseEntity
    {
        public int Name { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
