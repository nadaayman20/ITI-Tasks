
using Day2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Day2.Data.Context
{
    public class AppDBContect : DbContext
    {
        public AppDBContect(DbContextOptions option) : base(option)
        {

        }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Department> Department { get; set; }

    }
}


