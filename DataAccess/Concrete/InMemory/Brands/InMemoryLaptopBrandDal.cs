using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryLaptopBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryLaptopBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, BrandName = "Acer"},
                new Brand{BrandId = 2, BrandName = "Monster"},
                new Brand{BrandId = 3, BrandName = "ASUS"},
                new Brand{BrandId = 4, BrandName = "DELL"},
                new Brand{BrandId = 5, BrandName = "LENOVO"}
            };
        }

        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetByld(int brandId)
        {
            return _brands.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            brandToUpdate.BrandName = brand.BrandName;
        }
    }
}
