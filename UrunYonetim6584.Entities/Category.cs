using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetim6584.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public List<Product> Products { get; set; } //burada Category ile Product classları arasında 1'e çok bir ilişki kurduk. Yani 1 kategorinin 1'den çok ürünü olabilir.
    }
}
