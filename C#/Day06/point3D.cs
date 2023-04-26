using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class point3D
    {
        int X, Y, Z;
        public point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public point3D() : this(0, 0, 0)
        {

        }
        public void Show()
        {
            Console.WriteLine($"Point Coordinates: ({X},{Y},{Z})");
        }
        public static explicit operator string(point3D p)
        {
            return $"({p.X},{p.Y},{p.Z})";
        }
        public static bool operator ==(point3D P1, point3D p2)
        {
            return (P1.X == p2.X && P1.Y == p2.Y && P1.Z == p2.Z);
        }

        public static bool operator !=(point3D P1, point3D p2)
        {
            return (P1.X != p2.X || P1.Y != p2.Y || P1.Z == p2.Z);
        }
    }
}
