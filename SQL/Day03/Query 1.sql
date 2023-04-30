--Select *  from Employee;

--Select Fname ,Lname, Salary, Dno from Employee;

--Select Pname ,Plocation, Dnum from Project;

--Select Fname +' ' +Lname as fullname , Salary * 0.1 as ANNUALCOMM  from Employee ;

--Select SSN, Fname  from Employee where Salary >1000;
--Select SSN, Fname  from Employee where Salary * 12 >10000;
--Select Fname , Salary from Employee where Sex='F';

--Select Dnum, Dname from Departments where MGRSSN = 968574;
--Select Pname, Plocation from Project where Dnum =10;

Select Dname,Dnum, Fname,Superssn from Departments as d , Employee as e
where d.MGRSSN = e.SSN

Select Dname,Pname from Departments as d , Project as p
where d.Dnum = p.Dnum

Select *  from Dependent as d , Employee as e
where d.ESSN= e.SSN

Select Pname,Pnumber,Plocation from Project where City ='Cairo' oR City ='Alex' 

Select * from Project where Pname LIKE 'a%'

Select * from Employee  where Dno=30 and Salary BETWEEN 1000 AND 2000

select SSN , Fname +' '+Lname [Full Name] ,Dno
from Employee e inner join Works_for w
on e.SSN = w.ESSn and w.Hours*7>=10 and e.Dno=10
inner join Project p
on w.Pno=p.Pnumber and p.Pname='AL Rabwah'


select X.Fname +' '+ X.Lname as StudName ,Y.Fname +' '+ Y.Lname as Supername
from Employee X inner join  Employee Y
on y.SSN=x.Superssn  and Y.Fname +' '+ Y.Lname='Kamel Mohamed'

Select Fname +' '+Lname [Full Name]
From Employee as e inner join  Departments as d 
on e.Dno=d.Dnum inner join Project p
on p.Dnum =d.Dnum Order by p.Pname

Select pnumber ,Pname ,Lname ,Address,Bdate from Project p inner join  Departments d
on  p.Dnum =d.Dnum and City ='Cairo' inner join Employee e
on e.SSN=d.MGRSSN

Select * from Employee as e,Departments as d where e.SSN =d.MGRSSN

Select * from Employee as e Left outer join Dependent as d   on e.SSN=d.ESSN

insert into Employee (SSN,Fname ,Superssn ,salary ,Dno)values(102672,'nada',112233,3000,30) 

insert into Employee (SSN,Fname,Lname )values(102660,'Mariam','Naser') 

update Employee
set Salary = Salary+ Salary * 0.2
where SSN=102260
