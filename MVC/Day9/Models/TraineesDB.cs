using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Day9.Models
{
    public class TraineesDB: DbContext
    {
        public TraineesDB(DbContextOptions<TraineesDB> options) : base(options)
        {

        }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Track> Tracks { get; set; }

    }
}
