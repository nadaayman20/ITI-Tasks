using Day9.Models;
using System.Collections.Generic;

namespace Day9.RepoServices
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();
        public Course GetDetails(int id);
        public void Insert(Course crs);
        public void UpdateCourse(int id, Course crs);
        public void DeleteCourse(int id);
    }
}
