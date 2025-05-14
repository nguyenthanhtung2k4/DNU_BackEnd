using Microsoft.AspNetCore.Mvc;

namespace Models_View.Controllers
{
    public class StudentControllercs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}


