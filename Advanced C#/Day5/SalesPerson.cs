using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; } = 4000;
        public bool CheckTarget(int Quota)
        {
            if(Quota >= AchievedTarget)
            {
                return true;
            }
            else
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.Target });
                return false;   
            }
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Retirement || e.Cause == LayOffCause.Target)
            {

                base.OnEmployeeLayOff(e);
            }
        }

    }
}
