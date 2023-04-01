using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.Data
{
    public class DatabaseContext : DbContext //DbContext classı nuget'dan yüklediğimiz entityframawork'ten geliyor.
    {
        public DbSet<Category> Categories { get; set; } //veritabanı tablolarımızı temsil eden dbsetler
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; } 

        public DatabaseContext() : base("name=UrunYonetimiDb")
        {
            Database.SetInitializer(new DBInitializer());//DBInitializer classımızı bu şekilde kurucu metotta çağırıyruz çalışması için
        }
    }
}
