namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, max = 0, sum = 0;

            #region task1

            do
            {
                Console.WriteLine("Enter a Number");
                num = int.Parse(Console.ReadLine());
                sum += num;


            } while (!(sum >= 100 || num == 0));

            Console.WriteLine($"The Sum is {sum}");

            #endregion

            ////==========================================

            #region task2
            string str = "Hello World";

            string[] str2 = str.Split(' ');
            for (int i = str2.Length - 1; i >= 0; i--)
            {
                Console.Write(str2[i]);
            }
            Console.WriteLine();

            #endregion

            //=========================================

            #region task3

            Console.WriteLine("Enter 3 numbers");

            for (int i = 1; i <= 3; i++)
            {
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Max is {max}");


            #endregion

            //==========================================

            #region task4


            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write($"{item} is Even \n");
                }
                else
                {
                    Console.Write($"{item}  is Odd \n");
                }

            }
            #endregion


            #region task5
          
            Console.WriteLine("Enter Your Choise\n1- New\n2- Display\n3- Exit");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("1) New ");
                    break;
                case 2:
                    Console.WriteLine("2) Display ");
                    break;
                case 3:
                    Console.WriteLine("3) Exit ");
                    break;
                default:
                    Console.WriteLine("Enter a Valid value");
                    break;
            }
            #endregion


            #region task6
           
            do
            {
               
                Console.WriteLine("Enter Your Choise\n1- New\n2- Display\n3- Exit");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("1) New ");
                        break;
                    case 2:
                        Console.WriteLine("2) Display ");
                        break;
                    case 3:
                        Console.WriteLine("3) Exit ");
                        break;
                    default:
                        Console.WriteLine("Enter a Valid value");
                        break;
                }

            } while(num != 3 );
            #endregion
        }

    }
}