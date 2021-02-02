using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory.Categorys
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categorys;

        public InMemoryCategoryDal()
        {
            _categorys = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName = "Telefon"},
                new Category{CategoryId = 2, CategoryName = "Laptop"}
            };
        }

        public void Add(Category category)
        {
            _categorys.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categorys.SingleOrDefault(c => c.CategoryId == c.CategoryId);
            _categorys.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categorys;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categorys.SingleOrDefault(c => c.CategoryId == category.CategoryId);
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}
