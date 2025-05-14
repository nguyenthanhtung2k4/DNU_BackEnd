using Microsoft.AspNetCore.Mvc;
using Test1.Models;

namespace Test1.Controllers

{
    public class HomeController1 : Controller
    {
        private static List<Students> _students = new List<Students>
        {
            new Students { Id = 1, Name = "Nguyen Van A" },
            new Students { Id = 2, Name = "Le Thi B" }
        };

        // [HttpGet] - Hiển thị danh sách sinh viên
        [HttpGet]
        public IActionResult Index()
        {
            return View(_students); // View: Index.cshtml
        }

        // [HttpGet] - Hiển thị form tạo mới
        [HttpGet]
        public IActionResult Create()
        {
            return View(); // View: Create.cshtml
        }

        // [HttpPost] - Nhận dữ liệu từ form Create
        [HttpPost]
        public IActionResult Create(Students student)
        {
            _students.Add(student);
            return RedirectToAction("Index");
        }

        // [ActionName] - Đổi tên action khi gọi từ view hoặc URL
        [HttpGet]
        [ActionName("ThongTin")]
        public IActionResult Details()
        {
            return Content("Đây là trang thông tin sinh viên.");
        }

        // [NonAction] - Không phải là action
        [NonAction]
        public string HelperMethod()
        {
            return "Chức năng hỗ trợ nội bộ.";
        }
    }
}
