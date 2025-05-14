using System.Diagnostics;
using ActionSelctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionSelctor.Controllers
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

        //có  3 Action  Sellector ~~ Action Attribute
        //1 NON ACTION
        [NonAction]
        public int Tong(int x, int y) => x + y;
        [ActionName("Them moi")]
        //2 Action  Name:  Đặt tên mới cho Action
        [HttpGet]
        public IActionResult Create( )

        {
            return View();
        }

        //3 Action Verb :  Xác định Http Method  của Action đó
        //Cac  phuong thuc :  GET, POST, PUT,  PATCH, DELETE...
        [HttpPost]
        public IActionResult Create(string values)
        {
            return Content("Success!");
        }
        
    }
}
