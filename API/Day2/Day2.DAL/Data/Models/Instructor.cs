using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Data.Models
{
    public class Instructor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int SSN { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "The Name Must be in {1} , {0}")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Range(22, 60)]
        public int Age { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }
        [Required]
        [Range(10000, 50000)]
        public decimal Salary { get; set; }
        [Required]
        [AgeCustomValidation]
        public DateTime DOB { get; set; }

        [Required]
        [ForeignKey("Department")]
        public int DeptID { get; set; }

        public virtual Department? Department { get; set; }





    }
}
