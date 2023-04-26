using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public enum Gender {
        Male, Female
    };
    public enum Securitylevel {
        Guest,
        Developer, 
        Secretary, 
        DBA 
    };

    struct HireDate
    {
        int day;
        int month;
        int year;

        public HireDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }
        public int GetDay()
        {
            return day;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }

        public int GetMonth()
        {
            return month;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }

        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
    }
    internal class Employee
    {
        private int id;
        private Securitylevel securitylevel;
        private Gender gender;
        private float salary;
        private HireDate date;

        #region Property

        public HireDate Hiredate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value >= 1000)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Enter Valid ID");
                }
            }
        }

        public Securitylevel Securitylevel
        {
            get
            {
                return securitylevel;
            }
            set
            {

                securitylevel = value;
            }

        }

        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 3500)
                {
                    salary = value;
                }
                else
                    Console.WriteLine("Enter Valid Salary  ");
            }
        }


        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }

        }

        public void ShowInfo()
        {
            Console.Write($"ID:{id}\tSalary:{salary}\tGender:{gender}\tHiringDate: {date.GetDay()}-{date.GetMonth()}-{date.GetYear()}\t\tSecurityLevel:{securitylevel}\n");

        }
  
    }
}

