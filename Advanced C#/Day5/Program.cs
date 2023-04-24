namespace Day_5
{
    internal class Program
    {
        static void Main()
        {
            Department SD = new() { DeptID = 1, DeptName = "IT" };

            Club c = new() { ClubID = 1, ClubName = "The Club" };

            Employee e1 = new() { EmployeeID = 1, BirthDate = new(1960, 7, 5), VacationStock = 15 };
            Employee e2 = new() { EmployeeID = 2, BirthDate = new(1940, 12, 1), VacationStock = 5 };
            SalesPerson e3 = new() {EmployeeID = 3,BirthDate = new(1996, 2, 13), AchievedTarget = 2000};

            SalesPerson e4 = new(){ EmployeeID = 4,BirthDate = new(1940, 8, 13), AchievedTarget = 5000};

            BoardMember e5 = new(){ EmployeeID = 5};

            SD.AddStaff(e1);
            SD.AddStaff(e2);
            SD.AddStaff(e3);
            SD.AddStaff(e4);
            SD.AddStaff(e5);
    

            c.AddMember(e1);
            c.AddMember(e2);
            c.AddMember(e3);
            c.AddMember(e4);
            c.AddMember(e5);
     

    
            SD.ALLEmployess();
            c.AllMembers();

            e1.RequestVacation(new(2023, 3, 20), new(2023, 4, 1));
            e3.RequestVacation(new(2023, 4, 15), new(2023, 6, 15));


            e2.EndOfYearOperation();
            e4.EndOfYearOperation();

            SD.ALLEmployess(); 

            c.AllMembers(); 


            e3.CheckTarget(2000);

            SD.ALLEmployess();

            c.AllMembers(); 

            e5.Resign();

            SD.ALLEmployess(); 

            c.AllMembers(); 
        }
    }
}