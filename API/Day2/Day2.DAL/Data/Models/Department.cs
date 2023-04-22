using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Data.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Locations { get; set; }
        [Required]
        public string Branches { get; set; }
        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        public IEnumerable<Instructor> Instructors { get; set; }
    }
}

