namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");

            Console.WriteLine("Enter First Number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} + {num2} = " + ( num1 + num2));
            Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
            Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
            Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));


        
            //Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            //Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            //Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            //Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

        }
    }
}