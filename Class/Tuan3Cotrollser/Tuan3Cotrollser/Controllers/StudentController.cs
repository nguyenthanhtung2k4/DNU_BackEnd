using Microsoft.AspNetCore.Mvc;
using Tuan3Cotrollser.Models;

namespace Tuan3Cotrollser.Controllers
{
    public class StudentController : Controller
    {

        private static readonly List<Student> _Student = new List<Student>()
        {
            new Student()
            {
                Id="1771020729",
                Name= "Nguyen thanh tung", 
                Adr="HN"

            },
            new Student()
            {
                Id=" 12234",
                Name= "Nguyen thanh tung ",
                Adr="HN2"

            },
            new Student()
            {
                Id=" 17710230729",
                Name= "Nguy3en thanh tung ",
                Adr="HN3"

            }
        };
           //  Action

        public IActionResult Index()
        {
            return View(_Student);
        }

        public IActionResult Create()
        {
            return View();  
        }

        //  có 4 cách  sử dụng tiếp nhận tham số
        // C1:   Sử dụng  request
        public IActionResult ReceiveWithRequest()
        {
            Student student = new Student();
            student.Id = Request.Form["Id"]; // laay ra iD
            student.Name = Request.Form["Name"]; // laay ra name
            student.Adr = Request.Form["Adr"]; // laay ra Adr

            _Student.Add(student); //  them vao   danh sach
            return(RedirectToAction("Index"));
        }


        //  C2  su dung  IFormCollection
        public IActionResult ReceiveFormCollection(IFormCollection from)
        {

            Student student = new Student();
            student.Id = Request.Form["Id"]; // laay ra iD
            student.Name = Request.Form["Name"]; // laay ra name
            student.Adr = Request.Form["Adr"]; // laay ra Adr

            _Student.Add(student); //  them vao   danh sach
            return (RedirectToAction("Index"));
        }
        //  C3 Su duing  ACtion Arguments 
        public IActionResult ActionArguments( string  Id, string  Name,  string Adr)
        {
            Student student = new Student();
            student.Id=Id;
            student.Name=Name;
            student.Adr=Adr;


            _Student.Add(student); //  them vao   danh sach
            return (RedirectToAction("Index"));
        }

        //C4 Su dung  Models:
        //-Tạo một class  trong thuộc tính  tên với name của thẻ
        //Input trên  form   hoặc  key  trong query Striung
        //- các  thuộc tính phải có mức độ  triu  cập là public

        public IActionResult ReceiveWithModels(Student student)
        {
            _Student.Add(student);
            return (RedirectToAction("Index"));
        }


    }
}
