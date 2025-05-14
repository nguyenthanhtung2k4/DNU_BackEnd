using Microsoft.AspNetCore.Mvc;

namespace Tuan2.Controllers
{
    public class HelloController1 : Controller
    {
        // GET: HelloController1>
        public ActionResult Index()
        {
            return View();
        }

        public  IActionResult SayHello(){
            return View();
        }

    }
}
