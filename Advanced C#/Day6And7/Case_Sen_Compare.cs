using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Case_Sen_Compare : IComparer<string>
    {
        public int Compare(string? x, string? y) => x.ToUpper().CompareTo(y.ToUpper());
    }
   
}
