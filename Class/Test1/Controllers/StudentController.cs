using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyMvcApp.Controllers
{
    public class StudentController : Controller
    {
        // Danh sách lưu tạm thời
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Tùng", Adr = "Hà Nội" },
            new Student { Id = 2, Name = "Mai", Adr = "Đà Nẵng" }
        };

        // GET: Student/Index
        [HttpGet]
        public IActionResult Index()
        {
            return View(students);  // Truyền danh sách sang View
        }

        // GET: Student/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");  // Trở về trang danh sách
        }
    }
}
