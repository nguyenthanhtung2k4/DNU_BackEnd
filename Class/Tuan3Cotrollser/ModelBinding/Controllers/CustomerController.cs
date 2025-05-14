using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create() {
            return View();

        }
    //FromRoute
        //[HttpPost]
        //public IActionResult Create( [FromRoute]string Id, Customer customer)
        //{
        //    return Content($"Id in  route: {Id} , Id in form : {customer.Id}");
        //}


    //Query  http
        [HttpPost]
        public IActionResult Create([FromQuery] string Name, Customer customer)
        {
            return Content($"Id in  Query: {Name} , Id in fromQuery : {customer.Name}");
        }



    }
}
