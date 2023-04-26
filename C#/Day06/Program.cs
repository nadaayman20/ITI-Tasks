namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1

            Console.WriteLine("Enter 2 3D Points");
            Console.WriteLine();
            int x1, y1, z1;

            Console.WriteLine($"Enter First Point: ");
            while (!int.TryParse(Console.ReadLine(), out x1))
            {
                Console.WriteLine("Enter a valid number");
            }

            while (!int.TryParse(Console.ReadLine(), out y1))
            {
                Console.WriteLine("Enter a valid number");
            }

            while (!int.TryParse(Console.ReadLine(), out z1))
            {
                Console.WriteLine("Enter a valid number");
            }
            point3D p1 = new point3D(x1, y1, z1);
            p1.Show();
            Console.WriteLine();

            int x2, y2, z2;
            Console.WriteLine($"Enter Second Point: ");
            while (!int.TryParse(Console.ReadLine(), out x2))
            {
                Console.WriteLine("Enter a valid number");
            }

            while (!int.TryParse(Console.ReadLine(), out y2))
            {
                Console.WriteLine("Enter a valid number");
            }

            while (!int.TryParse(Console.ReadLine(), out z2))
            {
                Console.WriteLine("Enter a valid number");
            }
            point3D p2 = new point3D(x2, y2, z2);
            p2.Show();
            Console.WriteLine();

            //string point1, point2;

            //point1 = (string) p1;
            //point2 = (string) p2;
            //Console.WriteLine($"Point 1 : {point1} - Point 2 :{point2");


            if (p1 == p2)
            {
                Console.WriteLine("P1 == P2");
            }
            else
                Console.WriteLine("P1 != P2 ");

            Console.WriteLine();
            #endregion


            #region task 2
            int a, b;
            Console.WriteLine("Enter First Number ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($" Sum is : {Math.Sum(a, b)} --- Subtracct is : {Math.Subtract(a, b)} --- Multiply is : {Math.Multiply(a, b)} --- Divation is : {Math.Divation(a, b)} ");

            Console.WriteLine();
            #endregion

            #region task 3

            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(3600);
            Duration D3 = new Duration(7800);


            D1.Show();
            D2.Show();
            D3.Show();
            if (D1 == D2)
            {
                Console.WriteLine("D1 == D2");
            }
            else if (D1 > D2)
            {
                Console.WriteLine("D1 > D2");
            }
            else
                Console.WriteLine("D1 < D2");

            #endregion
        }
    }
}