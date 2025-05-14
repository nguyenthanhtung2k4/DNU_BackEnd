using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tuan3_1.Models;

namespace Tuan3_1.Controllers
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


        //  Cach  hai  routing 
        // -  C2:  Atttribuild 
        public IActionResult About()
        {
            return View();
        }
        [Route("trang-chu/lien_he")]

        public IActionResult Contact() {
            return View();

        
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
