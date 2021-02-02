using Business.Concrete;
using DataAccess.Concrete.InMemory.Products;
using DataAccess.Concrete.InMemory.Categorys;
using Entities.Concrete;
using System;
using DataAccess.Concrete.InMemory;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());
            CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
            BrandManager brandManager = new BrandManager(new InMemoryLaptopBrandDal());
            BrandManager brandManager1 = new BrandManager(new InMemoryTelephoneBrandDal());
            InMemoryProductDal ınMemoryProductDal = new InMemoryProductDal();
            Product product1 = new Product() { ProductName = "Telefon", Id = 4 };

            ınMemoryProductDal.Delete(product1);

            Console.WriteLine("////////////////////////");

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName + " : " + product.Explanation);
            }

            Console.WriteLine("////////////////////////");

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryId + " : " + category.CategoryName);
            }

            Console.WriteLine("////////////////////////");

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " : " + brand.BrandName);
            }

            Console.WriteLine("////////////////////////");

            foreach (var brand in brandManager1.GetAll())
            {
                Console.WriteLine(brand.BrandId + " : " + brand.BrandName);
            }

            //Output ==>

            //4 : Silindi
            //////////////////////////
            //XX - 1 : Oyun Telefonu
            //6XYZ - 27 : 1050Tİ EKRAN KARTI
            //ACX - 257 : 16 GB RAM
            //////////////////////////
            //1 : Telefon
            //2 : Laptop
            //////////////////////////
            //1 : Acer
            //2 : Monster
            //3 : ASUS
            //4 : DELL
            //5 : LENOVO
            //////////////////////////   
            //1 : Samsung
            //2 : Apple
            //3 : Xiaomi
            //4 : LG
            //5 : Nokia
        }
    }
}
