using System.Diagnostics;
using ActionResults.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionResults.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //ActionResults :  Xác định kiểu trả về 
        //1 ContenResults
        public ContentResult getContent()
        {
            return Content("Thanhtung CNTT 17-15");
        }
        //2 View Results
        public ViewResult getView()
        {
            return View();
        }
        //3 File Results 
        public FileResult getFile()
        {
            return File("Path", "contenType");
        }

        //4 JsonResults
        public JsonResult getJson()
        {
            return Json("Json()");
        }

        //5 RedirectResults
        public RedirectResult redirectToHome()
        {
            return Redirect("/Home/Index");
        }

        //6 RedirecToActionResults
        public RedirectToActionResult redirectTo()
        {
            //Chuyen  huong den Action co cung mot controller

            return RedirectToAction("Index");
        }
    }
}
