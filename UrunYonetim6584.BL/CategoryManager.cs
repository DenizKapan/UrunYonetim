using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using UrunYonetim6584.Data;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.BL
{
    public class CategoryManager : ICategoryManager
    {
        //iş(BL) katmanından data ve entities'e erişmek için referances'a sağ tık, add referance diyerek data ve entities katmanlarına tik atıp ok diyerek erişim veriyoruz yoksa kullanamayız diğer katmandakileri.
        DatabaseContext context = new DatabaseContext();
        public void Add(Category category)
        {
            context.Categories.Add(category);
        }

        public void Delete(Category category)
        {
            context.Categories.Remove(category);
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategory(int id)
        {
                return context.Categories.Find(id);
        }

        public int Save()
        {
                return context.SaveChanges();
        }

        public void Update(Category category)
        {
            context.Categories.AddOrUpdate(category);
        }
    }
}
