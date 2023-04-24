using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_P3
{
    internal class student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

}
