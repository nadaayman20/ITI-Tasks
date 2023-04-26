using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Day05
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            String fulldate;
            string idstr, strseclev, gender;
            

            Employee[] employees = new Employee[3];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();

                int id;
                do
                {
                    Console.Write("Please Enter id:");
                    idstr = Console.ReadLine();
                   
                }
                while (!(int.TryParse(idstr, out id)));

                employees[i].ID(id);

                Securitylevel level;
                do
                {
                    Console.WriteLine("Please Enter Security Level");
                    strseclev = Console.ReadLine();
                   
                }
                while (!Enum.TryParse(strseclev,true, out level));

                employees[i].Securitylevel(level);

                do
                {
                    Gender gen;
                    Console.WriteLine("Please Enter Gender");
                    gender = Console.ReadLine();
                } while (!Enum.TryParse(gender, true, out gen));

                employees[i].Gender(gen);
                do {
                    int day, month, year;
                    string[] dateArr;
                    do
                {
                        
                        Console.Write("Please Enter the Date: ");

                    fulldate = Console.ReadLine();

                        dateArr = fulldate.Split(' ', '/', '-');
                }

                while (dateArr.Length != 3);

                
                        day = int.Parse(dateArr[0]);
                        month = int.Parse(dateArr[1]);
                        year = int.Parse(dateArr[2]);

                    if (day < 1 || day > 31 || month < 1 || month > 12 || year < 2015)
                        Console.WriteLine("Please Enter a Valid Date");

                } while (day < 1 || day > 31 || month < 1 || month > 12 || year < 2015);

                HireDate date = new HireDate(day, month, year);
                employees[i].Hiredate(date);
            }
            for (int i = 0; i <= employees.Length; i++)
            {
                Console.WriteLine($"Id is {employees[i].ID()}");
                Console.WriteLine($"Security Level is {employees[i].Securitylevel()}");
                Console.WriteLine($"Gender is {employees[i].Gender()}");
                Console.WriteLine($"Hire Date is {employees[i].Hiredate.GetDay()}/{employees[i].Hiredate.GetMonth()}/{employees[i].Hiredate.GetYear()}");

            }

        }
    }
} 