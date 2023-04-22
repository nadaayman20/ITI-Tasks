using Day2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repo
{
    public interface IInstructorRepo
    {
        public List<Instructor> GetAll();
        Instructor GetById(int id);
        public void Insert(Instructor ins);
        public void UpdateInstructor(int id, Instructor ins);
        public void DeleteInstructor(int id);
    }
}
