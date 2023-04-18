using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace Day4.Areas.HR.Data
{
   
    public enum Gender { Male, Female }

    [Table("EmployeeInfo")]
    public class Employee
    {


        [Key]
        public int empID { get; set; }

        [Required(ErrorMessage = "Enter Valid Name")]
        [MaxLength(30, ErrorMessage = "Too Long Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Valid Username")]
        [MaxLength(30, ErrorMessage = "Too Long Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter Valid Password")]
        [MaxLength(8, ErrorMessage = "Enter Valid password within range 1 to 8")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required]
        [Range(1000, 20000, ErrorMessage = "Enter Valid Salary within range 1000 to 20000 ")]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }


        [Required(ErrorMessage = "Enter Valid Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }


    }
}