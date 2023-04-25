using Employee;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees[] arr = new Employees[1];
            for(int i=0; i<arr.Length;i++)
            {
                Console.WriteLine("Enter ID");
                int id=int.Parse(Console.ReadLine());
                arr[i].SetId(id);

                Console.WriteLine("Enter security level");
               SecurityLevel level = (SecurityLevel)Enum.Parse(typeof(SecurityLevel), Console.ReadLine());
                arr[i].SetSecurityLevel(level);

                Console.WriteLine("Enter salary");
                float salary = float.Parse(Console.ReadLine());
                arr[i].SetSalary(salary);

                HireDate date= new HireDate();
                Console.WriteLine("Enter hire date");
                int day=int.Parse(Console.ReadLine());
                int month = int.Parse(Console.ReadLine());
                int year = int.Parse(Console.ReadLine());
                date.SetDay(day);
                date.SetMonth(month);
                date.SetYear(year);

                Console.WriteLine("Enter gender");
                Gender gender= (Gender) Enum.Parse(typeof(Gender), Console.ReadLine());
                arr[i].SetGender(gender);

            }

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine($"Id :{arr[j].GetId}");
                Console.WriteLine($"Hiredate :{arr[j].GetHireDate}");
                Console.WriteLine($"Salary :{arr[j].GetSalary}");
                Console.WriteLine($"Gender :{arr[j].GetGender}");
                Console.WriteLine($"security level :{arr[j].GetSecurityLevel}");
            }

        }
    }
}