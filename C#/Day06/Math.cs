using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Math
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Subtract(int x, int y)
        {
            return x - y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
        public static float Divation(int x, int y)
        {
            if (y != 0)
            {
                return (float)x / (float)y;
            }
            return 0;

        }
    }
}
