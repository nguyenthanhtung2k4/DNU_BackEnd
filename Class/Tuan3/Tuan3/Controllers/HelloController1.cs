using Microsoft.AspNetCore.Mvc;

namespace Tuan3.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public  IActionResult SayHello()
        {
            return View();
        }
    }
}
