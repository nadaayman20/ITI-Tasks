using API_Day2.Data.Context;
using Day2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repo
{
    public class DepartmentRepo : IDepartmentRepo
    {
        AppDBContect Context;
        public DepartmentRepo(AppDBContect context)
        {
            Context = context;
        }
        public void DeleteDepartment(int id)
        {
            Context.Remove(Context.Department.Find(id));
            Context.SaveChanges();
        }

        public List<Department> GetAll()
        {
            return Context.Department.ToList();
        }

        public Department GetById(int id)
        {
            return Context.Department.Find(id);
        }

        public void Insert(Department dep)
        {
            Context.Department.Add(dep);
            Context.SaveChanges();
        }

        public void UpdateDepartment(int id, Department dep)
        {
            Department DepaUpdated = Context.Department.Find(id);
            DepaUpdated.Name = dep.Name;
            DepaUpdated.Description = dep.Description;
            DepaUpdated.Locations = dep.Locations;
            DepaUpdated.Branches = dep.Branches;
            Context.SaveChanges();
        }
    }
}
