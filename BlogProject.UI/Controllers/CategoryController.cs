using BlogProject.BusinessLayer.Concrete;
using BlogProject.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetAllCategories();
            return View(values);
        }
    }
}
