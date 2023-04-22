using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    public class Courses
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public int Duration { get; set; }
    }
}
