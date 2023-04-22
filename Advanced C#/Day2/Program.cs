using System.Text;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine($"Enter The Size of Array ");
            size = int.Parse( Console.ReadLine() );

            int[] arr= new int[size];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter The value of Array {i} from {size}");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = 0;
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        num1 = j;
                        num2 = i;
                    }   
                    
                    if (num1 - num2 > max)
                    {
                        max = num1 - num2;
                    }
                 
                }
              
            }
            Console.WriteLine($"the longest distance between  them is {max-1} cells");

            Console.WriteLine();
            Console.WriteLine("==========================");

            ////// Task 2
           
            NIC n1 = NIC.CreateObj;
            n1.printData();
            NIC n2 = NIC.CreateObj;
            n2.printData();

            Console.WriteLine() ;

            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());

        }
    }
}