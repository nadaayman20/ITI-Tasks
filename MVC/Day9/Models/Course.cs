using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Day9.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }


        [Required]
        public String Topic { get; set; }

        [Required]
        public int Grade { get; set; }

        [Required]
        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }

        public virtual Trainee Trainee { get; set; }
    }
}
