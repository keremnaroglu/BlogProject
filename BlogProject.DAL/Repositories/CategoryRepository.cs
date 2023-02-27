using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete;
using BlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context c = new Context();
        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetCategories()
        {
            return c.Categories.ToList();
        }

        public void Update(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
