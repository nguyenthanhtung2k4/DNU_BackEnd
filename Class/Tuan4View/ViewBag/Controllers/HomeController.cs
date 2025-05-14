using System.Diagnostics;
using System.IO.Pipes;
using Microsoft.AspNetCore.Mvc;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        // Các cách truyền dữ liệu tuè controller sang View
        
        {
            /// 1>  Su dung   View Bag
            ViewBag.message1 = "View Bag  La một dynamic đề truyền dữ liệu từ Colltroller sang View trong cùng 1  request";
            ///2  Su dung ViewData
            ViewData["message2"] = "View data  la mot dictionnary  dung de  truyen du lieu trong View trong cung 1  Request  " +
                "Request  o  ben view phai thuc hien ep  kieu";
            List<string> messages = new List<string>
            {
                "Tung","nam","vuong"
            };
            ViewData["names"]=messages; 
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
    }
}
