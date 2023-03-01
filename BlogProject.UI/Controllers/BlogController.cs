using Microsoft.AspNetCore.Mvc;

namespace BlogProject.UI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
