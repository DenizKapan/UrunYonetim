using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.BL
{
    public interface ICategoryManager
    {
        List<Category> GetCategories();
        void Add(Category category);
        Category GetCategory(int id);
        void Update(Category category);
        void Delete(Category category);
        int Save();
    }
}
