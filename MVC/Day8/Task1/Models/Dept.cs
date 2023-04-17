﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Task1.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Emps = new HashSet<Emp>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}
