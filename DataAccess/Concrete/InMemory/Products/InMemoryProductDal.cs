using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory.Products
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id = 1, CategoryId = 1, ColorId = 1,  BrandId = 1, ProductName = "XX-1", UnitPrice = 1750, UnitInStock = 12, Explanation = "Oyun Telefonu"},
                new Product{Id = 2, CategoryId = 2, ColorId = 5, BrandId = 3 , ProductName = "6XYZ-27", UnitPrice = 9000, UnitInStock = 8, Explanation = "1050Tİ EKRAN KARTI"},
                new Product{Id = 3, CategoryId = 2, ColorId = 4, BrandId =2, ProductName = "ACX-257", UnitPrice = 8500, UnitInStock = 7, Explanation = "16 GB RAM" }
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.Id == product.Id);
            _products.Remove(productToDelete);
            Console.WriteLine(product.Id +" : " +  "Silindi");
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.Id == product.Id);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.Explanation = product.Explanation;
        }
    }
}
