﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTelephoneBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryTelephoneBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, BrandName = "Samsung"},
                new Brand{BrandId = 2, BrandName = "Apple"},
                new Brand{BrandId = 3, BrandName = "Xiaomi"},
                new Brand{BrandId = 4, BrandName = "LG"},
                new Brand{BrandId = 5, BrandName = "Nokia"}
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
