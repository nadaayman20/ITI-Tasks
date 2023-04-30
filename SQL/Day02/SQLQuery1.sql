Select *  from Employee;

Select Fname ,Lname, Salary, Dno from Employee;

Select Pname ,Plocation, Dnum from Project;

Select Fname +' ' +Lname as fullname , Salary * 0.1 as ANNUALCOMM  from Employee ;

Select SSN, Fname  from Employee where Salary >1000;
Select SSN, Fname  from Employee where Salary * 12 >10000;
Select Fname , Salary from Employee where Sex='F';

Select Dnum, Dname from Departments where MGRSSN = 968574;
Select Pname, Plocation from Project where Dnum =10;