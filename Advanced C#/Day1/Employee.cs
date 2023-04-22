using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Day1

//{
//    public enum Gender
//    {
//        Male, Female
//    };
//    public enum Securitylevel
//    {
//        Guest,
//        Developer,
//        Secretary,
//        DBA
//    };

//    struct HireDate
//    {
//        int day;
//        int month;
//        int year;

//        public HireDate(int _day, int _month, int _year)
//        {
//            this.day = _day;
//            this.month = _month;
//            this.year =_year;

//        }
//        public int GetDay()
//        {
//            return day;
//        }
//        public void SetDay(int day)
//        {
//            this.day = day;
//        }

//        public int GetMonth()
//        {
//            return month;
//        }
//        public void SetMonth(int month)
//        {
//            this.month = month;
//        }

//        public int GetYear()
//        {
//            return year;
//        }
//        public void SetYear(int year)
//        {
//            this.year = year;
//        }
//    }
//    internal class Employee:IComparable
//    {
//        private int id;
//        private string name;
//        private Securitylevel securitylevel;
//        private Gender gender;
//        private float salary;
//        private HireDate date;

//        public Employee(int _id,string _name,Securitylevel _securty, Gender _gen, float _salary ,HireDate _date)
//        {
//            this.id = _id;
//            this.name = _name;
//            this.securitylevel = _securty;
//            this.gender = _gen;
//            this.salary = _salary;
//            this.date = _date;

//        }
//        #region Property

//        public HireDate Hiredate
//        {
//            get
//            {
//                return date;
//            }
//            set
//            {
//                date = value;
//            }
//        }
//        public int ID
//        {
//            get
//            {
//                return id;
//            }
//            set
//            {
//                if (value >= 1000)
//                {
//                    id = value;
//                }
//                else
//                {
//                    Console.WriteLine("Enter Valid ID");
//                }
//            }
//        }
//        public string Name
//        {
//            get
//            { return name; }
//            set
//            {
//                if (value != null)
//                {
//                    name = value;
//                }
//            }
//        }

//        public Securitylevel Securitylevel
//        {
//            get
//            {
//                return securitylevel;
//            }
//            set
//            {

//                securitylevel = value;
//            }

//        }

//        public float Salary
//        {
//            get
//            {
//                return salary;
//            }
//            set
//            {
//                if (value >= 3500)
//                {
//                    salary = value;
//                }
//                else
//                    Console.WriteLine("Enter Valid Salary  ");
//            }
//        }


//        public Gender Gender
//        {
//            get
//            {
//                return gender;
//            }
//            set
//            {
//                gender = value;
//            }

//        }
//        public int CompareTo(object obj)
//        {
//            Employee e = obj as Employee;
           
//        }

//        public void ShowInfo()
//        {
//            Console.Write($"ID:{id}\tName:{name}\tSalary:{salary}\tGender:{gender}\tHiringDate: {date.GetDay()}-{date.GetMonth()}-{date.GetYear()}\t\tSecurityLevel:{securitylevel}\n");

//        }
//         public override string ToString() {
//            return String.Format($"{name} is taking {salary}");
//        }

//    }
//}

