using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day9.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Description { get; set; }

        public IEnumerable<Trainee> Trainees { get; set; }
    }
}
