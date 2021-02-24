using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID 
    //Open closed principle :  yaptıgın yazılama yeni bir özellik ekliyorsan mevcutdaki hiçbir koduna dokunamazssın
    class Program
    {
        static void Main(string[] args)
        {
            //Data Transformation object
             ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager prodcutManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = prodcutManager.GetProductDetails();
            if(result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
