using Day9.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Day9.RepoServices
{
    public class CourseRepoService : ICourseRepository
    {
        public TraineesDB Context { get; set; }
        public CourseRepoService(TraineesDB context) 
        {
            Context = context;
        }

        public List<Course> GetAll()
        {
            return Context.Courses.Include(c=>c.Trainee).ToList();
        }

        public Course GetDetails(int id)
        {
            return Context.Courses.FirstOrDefault(c =>c.ID == id);
        }

        public void Insert(Course crs)
        {
            Context.Courses.Add(crs);
            Context.SaveChanges();
        }

        public void UpdateCourse(int id, Course crs)
        {
            Course CourseUpdated = Context.Courses.Find(id);
            CourseUpdated.Topic = crs.Topic;
            CourseUpdated.Grade= crs.Grade;
            CourseUpdated.TraineeID= crs.TraineeID;
           
            Context.SaveChanges();
        }
        public void DeleteCourse(int id)
        {
            Context.Remove(Context.Courses.Find(id));
            Context.SaveChanges();
        }
    }
}
