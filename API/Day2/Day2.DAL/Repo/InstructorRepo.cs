using API_Day2.Data.Context;
using Day2.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repo
{
    public class InstructorRepo : IInstructorRepo
    {
        AppDBContect Context;
        public InstructorRepo(AppDBContect context)
        {
            Context = context;
        }
        public void DeleteInstructor(int id)
        {
            Context.Remove(Context.Instructors.Find(id));
            Context.SaveChanges();
        }

        public List<Instructor> GetAll()
        {
            return Context.Instructors.ToList();
        }

        public Instructor GetById(int id)
        {
            return Context.Instructors.Find(id);
        }

        public void Insert(Instructor ins)
        {
            Context.Instructors.Add(ins);
            Context.SaveChanges();
        }

        public void UpdateInstructor(int id, Instructor ins)
        {
            Instructor InstructorUpdated = Context.Instructors.Find(id);
            InstructorUpdated.SSN = ins.SSN;
            InstructorUpdated.Name = ins.Name;
            InstructorUpdated.Email = ins.Email;
            InstructorUpdated.Age = ins.Age;
            InstructorUpdated.Address = ins.Address;
            InstructorUpdated.Phone= ins.Phone;
            InstructorUpdated.Password= ins.Password;
            InstructorUpdated.Salary= ins.Salary;
            InstructorUpdated.DOB= ins.DOB;
            InstructorUpdated.DeptID= ins.DeptID;
            Context.SaveChanges();

        }
    }
}
