using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    enum LayOffCause
    {
        Retirement, vacation, Target,Resign
    }

    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate{ get;set;}
        public int VacationStock { get; set; } = 0;

        public bool RequestVacation(DateTime From, DateTime To)
        {
            if(To == From || From >= To)
            {
                return false;
            }

            TimeSpan interval = To - From;
            int Days = interval.Days;

            if (Days <= VacationStock)
            {
                VacationStock -= Days;
                return true;
            }
            else
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.vacation });
                return false;
            }



        }
        public void EndOfYearOperation()
        {
            if (BirthDate != null)
            {
                DateTime Today = DateTime.Today;
                int y = BirthDate.Year ;
                int Age = Today.Year - y;

                if (BirthDate > Today.AddYears(-Age))
                    Age--;



                if (Age > 60)
                {
                    OnEmployeeLayOff(new() { Cause = LayOffCause.Retirement });
                }
            }
        
    }
        public override string? ToString()
        {
            return $"(Employee ID: {EmployeeID})";
        }
    }

}
