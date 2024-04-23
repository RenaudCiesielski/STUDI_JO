using Microsoft.AspNetCore.Mvc;

namespace jeuxOlympiques.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
