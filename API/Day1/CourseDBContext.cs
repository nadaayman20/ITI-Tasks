using Day1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day1
{
    public class CourseDBContext : DbContext
    {
        public CourseDBContext(DbContextOptions<CourseDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Courses> Courses { get; set; }
    }
}
