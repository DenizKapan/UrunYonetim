using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetim6584.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; } //entityframwerk bu id değerini otomatik olarak primarykey ve otomatik artan sayı olarak veritabanında ayarlayacak
        public string Name { get; set; }
        public string Description { get; set; }
        
        public string Brand { get; set; }
        public bool IsActive { get; set; }
        public int Stock { get; set; }
        public decimal Price{ get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; } //entityframework bu ilişkiye bakarak CategoryId propertysini foreignkey olarak işaretleyecek
        public Category category { get; set; } //product ile category classları arasında 1'e 1 ilişki kurduk. Yani her ürünün 1 kategorisi olacak.
    }
}
