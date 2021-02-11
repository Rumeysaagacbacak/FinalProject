using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //context:Db tabloları ile proje classlarını bağlamak.
    public class NorthwindContext:DbContext
    {
        //tablomuz hangi veri tabanı ile ilişkili belirtecegimiz yer 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        //hangi tabloya ne denk gelecek.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
