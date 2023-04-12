using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Day9.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Trainee
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
        public string Mobile { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        public IEnumerable<Course> Courses { get; set; }

        [Required]
        [ForeignKey("Track")]
        public int TrackID { get; set; }

        public virtual Track Track { get; set; }
    }
}
