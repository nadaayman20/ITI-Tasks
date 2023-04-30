Use Company_SD
-----(1)-----
Select Dependent_name ,d.Sex 
from Dependent d , Employee e 
where d.ESSN = e.SSN and d.Sex='F'and e.Sex='F' 
union 
Select Dependent_name ,d.Sex 
from Dependent d , Employee e 
where d.ESSN = e.SSN and d.Sex='M'and e.Sex='M' 

----(2)------
Select  Pname, sum( hours*7)as[Total Hours]  from Project p , Works_for w where p.Pnumber = w.Pno
group by Pname

---(3)----

select d.* from Departments d , Employee e
where d.Dnum = e.Dno and ssn=(select min(e.ssn) from Employee)

---(4)----
Select  d.Dname, MAX(Salary) as [Max],MIN(Salary) as [Min],AVG(Salary)as [Average]
from Departments d, Employee group by d.Dname 

---(5)----	
Select Fname+' '+ lname as [Full-name] from Employee e inner join Departments d
on e.ssn=d.MGRSSN left outer join Dependent dep
on e.ssn=dep.ESSN where dep.ESSN is null

---(6)----
Select d.Dname,d.Dnum , count(e.ssn) as [Num of Emp] from Departments d ,Employee e 
where d.MGRSSN =e.SSN 
group by d.Dname,d.Dnum 
having AVG(Salary)< (Select AVG(salary)from Employee)

----(7)-----

Select Fname+' '+ lname as [Full-name] ,p.Pname from Employee e inner join Works_for w 
on e.SSN=w.ESSn inner join Project p 
on  w.Pno = p.Pnumber  
order by [Full-name],e.Dno

----(8)-------
select max(salary) from Employee
union all
select max(salary) from Employee

where Salary !=(select max(salary) from Employee)

----(9)----

Select e.Fname+' '+ e.lname as [Full-name] from Employee e 
intersect
Select Dependent_name from Dependent

----(10)----
select ssn, fname+' '+lname from Employee e
where Exists(select ESSN from Dependent d where e.SSN=d.ESSN)

---(11)-----
insert into Departments (Dname,Dnum,MGRSSN,[MGRStart Date]) values ('DEPT IT',100,112233,'1-11-2006')

---(12)----
update Departments set MGRSSN = 968574 where Dnum = 100
update Departments set MGRSSN = 102672 where Dnum = 20
update Employee set Superssn = 102672 where SSN = 102660

---(13)---
delete Dependent where ESSN=223344
delete Works_for where ESSN=223344
update Departments set MGRSSN=102672 where MGRSSN=223344
update Employee set Superssn=102672 where Superssn=223344
delete Employee where SSN=223344


----(14)---
update Employee
set Salary = (salary * 0.3) + Salary
from Employee e, Works_for w ,Project p
where e.SSN=w.ESSn and p.Pnumber=w.Pno and p.Pname='Al Rabwah'
