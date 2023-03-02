using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete;
using BlogProject.DAL.Repositories;
using BlogProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c = new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
             
        }
    }
}
