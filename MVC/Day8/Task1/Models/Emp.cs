using System;
using System.Collections.Generic;

#nullable disable

namespace Task1.Models
{
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public double? EmpSalary { get; set; }
        public DateTime? EmpHdate { get; set; }
        public int DId { get; set; }
        public int? CtyId { get; set; }

        public virtual Dept DIdNavigation { get; set; }
    }
}
