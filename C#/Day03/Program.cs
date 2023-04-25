
namespace Day03
{
    internal struct Employee
    {
        #region struct
        //public string Name;
        //public string Address;
        //public int Age;
        //public float Salary;
        //public void PrintInfo()
        //{
        //    Console.WriteLine($"Name: {Name} - Age: {Age} - Address: {Address} - Salary: {Salary:c}");
        //}
        #endregion
    }
    internal class Program
    {
        #region swap

        //public static void swap(int x , int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void swapRef(ref int x,ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region menu
        public static int sum(int x ,int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        public static int multiply(int x, int y)
        {
            return x * y;
        }
        public static int devide(int x, int y)
        {
            return x / y;
        }
        #endregion
        static void Main(string[] args)
        {

            #region task 1
            //int size = 0;
            //Console.WriteLine("Enter Size of Array");

            //size = int.Parse(Console.ReadLine());

            //Employee[] employees = new Employee[size];

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine($"Enter {employees.Length} Employee data");
            //    Console.WriteLine("Enter Your Name");
            //    employees[i].Name = Console.ReadLine();
            //    Console.WriteLine("Enter Your Address");
            //    employees[i].Address = Console.ReadLine();
            //    Console.WriteLine("Enter Your Age");
            //    employees[i].Age = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Your Salary");
            //    employees[i].Salary = float.Parse(Console.ReadLine());

            //    employees[i].PrintInfo();

            //}

            #endregion

            #region task 2
            //int a = 5, b = 7;
            //Console.WriteLine($"a : {a} - b : {b} --- before swap ");
            //swap(a, b);
            //Console.WriteLine($"a : {a} - b : {b} --- after swap ");

            //Console.WriteLine($"a : {a} - b : {b} --- before swap ");
            //swapRef(ref a,ref b);
            //Console.WriteLine($"a : {a} - b : {b} --- after swap ");
            #endregion

            #region task 3
            int num1, num2 , choise;

            Console.WriteLine("Enter First Number");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(" 1- Sum\n 2- Substract\n 3-multiply\n 4-Devide ");
                Console.WriteLine("Enter Your Choise");
                choise = int.Parse(Console.ReadLine());
                switch(choise)
                {
                    case 1:
                        Console.WriteLine($"{num1} + {num2} = {sum(num1, num2)}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} - {num2} = {sub(num1, num2)}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} * {num2} = {multiply(num1, num2)}");
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Enter Valid Number");
                        }
                        else {
                            Console.WriteLine($"{num1} / {num2} = {devide(num1, num2)}");
                        }
                        break;
                       
                }


            } while (choise != 0);


            #endregion
        }
    }
}