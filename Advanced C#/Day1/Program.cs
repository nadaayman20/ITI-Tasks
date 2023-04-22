namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size1;
            Console.WriteLine("Please Enter Num of student");
            size1 = int.Parse(Console.ReadLine());
            int size2;
            Console.WriteLine("Please Enter Num of student");
            size2 = int.Parse(Console.ReadLine());
            int[,] arr = new int[size1, size2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int grade;
                    do
                    {
                        Console.WriteLine("Enter Your Grade is ");
                        grade = int.Parse(Console.ReadLine());

                    } while (grade == null);

                    arr[i, j] = grade;
                }
            }

                 int sum;
                float avg ;
                int rows=arr.GetLength(0);
                int cols=arr.GetLength(1);

            //Sum of rows
            for(int i=0; i<rows; i++)
            {
                sum= 0;
                for(int j=0;j<cols; j++)
                {
                    sum +=  arr[i, j];
                }
               
                Console.WriteLine("Sum of " + (i + 1) + " row: " + sum);

            }

            //Average of Columns
            for (int i = 0; i < cols; i++)
            {
                sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    sum  += arr[j, i];
                }
                //Console.WriteLine("Sum of " + (i + 1) + " column: " + sum);
                avg=sum/rows;
                Console.WriteLine("Average of  " + (i + 1) + " column: " + avg);
            }



            /////////// Employee
           
         
        }
    }
 }
