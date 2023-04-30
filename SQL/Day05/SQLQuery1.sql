use ITI

--- (1)----
Select * from student where St_Age is not null

---(2)-----
Select distinct  Ins_Name from Instructor 

----(3)----
Select St_Id as [Student ID] ,St_Fname +' '+ St_Lname as [Student Full Name],Dept_Id as [Department name] from Student

----(4)----
Select Ins_Name , Dept_Name from Instructor i left outer join Department d
on i.Dept_Id=d.Dept_Id

----(5)----
Select St_Fname +' '+ St_Lname as [Student Full Name],Crs_Name ,Grade from Student s inner join Stud_Course st
on s.St_Id=st.St_Id inner join Course c
on st.Crs_Id=c.Crs_Id

----(6)----
Select count([Crs_Id])as [Num of Course] , Top_Name from Course c inner join Topic t 
on c.Top_Id=t.Top_Id
group by  Top_Name

-----(7)-----
Select max(Salary) as Max_Salary ,min(Salary) as Min_Salary from Instructor

----(8)-----
Select * from Instructor where Salary <(Select AVG(Salary)from Instructor)

----(9)-----
Select Dept_Name from Department d inner join Instructor i
on d.Dept_Id=i.Dept_Id 
where i.Salary=(select MIN(Salary)from Instructor)

-----(10)-----
Select top(2) Salary from Instructor order by Salary desc

----(11)-----

Select Ins_Name , coalesce (convert (varchar,Salary), 'bonus ') From Instructor

----(12)-----
Select AVG(Salary) as AVG_Salary from Instructor

----(13)----
Select stu.St_Fname , sup.* from Student stu , Student sup
where stu.St_super=sup.St_Id

---(14)----

Select Top(2) Salary
From (select Salary, Row_number() over(partition by dept_id order by Salary  desc) as RN
	  from Instructor) as Newtable
where RN<=2

-----(15)----

Select *
From (select *, Row_number() over(partition by dept_id order by newId() desc) as RN
	  from Student) as Newtable
where RN=1

