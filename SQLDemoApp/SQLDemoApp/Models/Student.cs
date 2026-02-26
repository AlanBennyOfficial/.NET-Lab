using System.ComponentModel.DataAnnotations;

namespace SQLDemoApp.Models
{
    public class Student
    {
        public int Usn { get; set; }
        [Required]
        [MaxLength(255)]

        public string FullName { get; set; }
        [Required]
        [EmailAddress]

        public string Email { get; set; }
        public string Department { get; set; }
        public Address? Address { get; set; }
    }
}
