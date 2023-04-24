using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string? DeptName { get; set; }
        public List<Employee> Staff = new();
        public void AddStaff(Employee E)
        {
           if(!Staff.Contains(E))
            {
                E.EmployeeLayOff += RemoveStaff;
                Staff.Add(E);
            }
            
        }
        ///CallBackMethod
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if ((sender is Employee Emp) && (Emp != null) && Staff.Contains(Emp))
            {
                Emp.EmployeeLayOff -= RemoveStaff;
                Staff.Remove(Emp);
            }

        }
        internal void ALLEmployess()
        {
            Console.WriteLine($"All Employees in {DeptName} are {string.Join(", ", Staff)}");
        }
    }
}
