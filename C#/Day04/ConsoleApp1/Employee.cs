using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    enum SecurityLevel
    {
        guest,
        developer,
        secretary,
        DPA
    }
    enum Gender
    {
        M,
        F
    }
    struct HireDate
    {
        int Day;
        int Month;
        int Year;

        public void SetDay(int day)
        {
            if (day > 0)
                Day = day;
        }
        public int GetDay() {
            return Day;
        public void SetMonth(int month)
        {
            Month = month;
        }
        public int GetMonth()
        { return Month; }
        public void SetYear(int year)
        {
            Year = year;
        }
        public int GetYear()
        { return Year; }

        public HireDate(int day,int month,int year)
        {
            Day= day;
            Month = month;
            Year = year;
        }
    }
    struct Employees
    {
        int Id;
        SecurityLevel securitylevel;
        float Salary;
        HireDate hiredate;
        Gender gender;

        public void SetId(int id)
        {
            if (id > 0)
                Id = id;
            else
                Console.WriteLine("Pleas enter correct Id");
        }
        public int GetId() {
               return Id;

        public void SetSecurityLevel(SecurityLevel securlevel)
        {
            securitylevel = securlevel;
        }
        public SecurityLevel GetSecurityLevel()
                return securitylevel;

        public void SetSalary(float salary)
        {
            if (salary >= 3500)
                Salary = salary;
        }
        public float GetSalary() {
                return Salary;
             }

        public void SetHireDate(HireDate date)
        {
            hiredate = date;
        }
        public HireDate GetHireDate() {
                return hiredate;
           }

        public void SetGender(Gender gen)
        {
            gender = gen;
        }
        public Gender GetGender() {
                return gender;
           }
        public Employees(int id, float salary, HireDate hire, Gender g, SecurityLevel level)
        {
            Id = id;
            Salary = salary;
            hiredate = hire;
            gender = g;
            securitylevel = level;

        }


    }
}
