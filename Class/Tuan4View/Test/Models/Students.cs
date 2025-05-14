using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Range(1, 100)]
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }

}
