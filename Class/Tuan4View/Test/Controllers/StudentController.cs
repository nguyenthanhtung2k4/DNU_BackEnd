using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                // Giả lập lưu dữ liệu vào DB
                return RedirectToAction("Success");
            }

            return View(student);
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}
