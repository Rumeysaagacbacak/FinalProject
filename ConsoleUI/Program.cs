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
            ProductManager prodcutManager = new ProductManager(new EfProductDal());
            foreach (var product in prodcutManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
