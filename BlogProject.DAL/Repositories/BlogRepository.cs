using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete;
using BlogProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Repositories
{
    public class BlogRepository : IBlogDAL
    {
        public void AddBlog(Blog blog)
        {
            using var c = new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public List<Blog> GetBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public void Update(Blog blog)
        {
            using var c = new Context();
            c.Update(blog);
            c.SaveChanges();
        }
    }
}
