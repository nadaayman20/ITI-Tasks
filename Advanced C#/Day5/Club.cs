using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String? ClubName { get; set; }
        List<Employee> Members = new();
        public void AddMember(Employee E)
        {
            if (!Members.Contains(E))
            {
                E.EmployeeLayOff += RemoveMember;
                Members.Add(E);
            }
        }
        ///CallBackMethod
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {

            if (e.Cause == LayOffCause.vacation && (sender is Employee Emp) && (Emp != null) && (Members.Contains(Emp)))
            {
                Emp.EmployeeLayOff -= RemoveMember;
                Members.Remove(Emp);
            }
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        internal void AllMembers()
        {
            Console.WriteLine($"All Members in {ClubName} is {string.Join(", ", Members)}");
        }
    }
}
