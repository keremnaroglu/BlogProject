using BlogProject.BusinessLayer.Concrete;
using BlogProject.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.UI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
