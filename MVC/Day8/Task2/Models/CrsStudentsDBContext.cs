using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Task2.Models;

namespace Task2.Models
{
    public class CrsStudentsDBContext : DbContext
    {
        public CrsStudentsDBContext(DbContextOptions<CrsStudentsDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Task2.Models.Course> Course { get; set; }

    }
}
