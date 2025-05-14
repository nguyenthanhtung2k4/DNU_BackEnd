using DependencyInjectionApp.Models;

namespace DependencyInjectionApp.Service
{
    public class StudentService : IStudentService
    {
        static List<Student> student = new List<Student>()
        {
            new Student() { Id = 1, Name = "Nguyen thanh tung", Phone = "123455677891" },
            new Student() { Id = 2, Name = "Nguyen thanh tung", Phone = "454546" },
            new Student() { Id = 3, Name = "Nguyen thanh tung", Phone = "4546" }
        };

        public List<Student> GetStudents()
        {
            return student;
        }
    }
}
