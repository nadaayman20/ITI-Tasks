using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Task2.Models
{
    public enum Gender
    {
        Male, Female
    }
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Valid Name")]
        [MaxLength(30, ErrorMessage = "Name is too Long ")]
        public string Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Enter Valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}