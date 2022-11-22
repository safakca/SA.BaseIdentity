
using Entity.Common;

namespace Entity.Concrete
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
