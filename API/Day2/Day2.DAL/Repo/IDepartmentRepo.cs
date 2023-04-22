using Day2.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repo
{
    public interface IDepartmentRepo
    {
        public List<Department> GetAll();
        Department GetById(int id);
        public void Insert(Department dep);
        public void UpdateDepartment(int id, Department dep);
        public void DeleteDepartment(int id);
    }
}
