using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Task2.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }


        [Required]
        public String Topic { get; set; }

        [Required]
        public int CourseGrade { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public virtual Student Student { get; set; }

    }
}
