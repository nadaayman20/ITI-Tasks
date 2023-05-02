use ITI
------(1)-------
alter view stdgrade
as select s.St_Fname+' '+s.St_Lname as [fullname], c.Crs_Name
from student s inner join Stud_Course sc
on s.St_Id = sc.St_Id and sc.Grade >50 inner join Course c
on c.Crs_Id = sc.Crs_Id

select * from stdgrade
GO

-----(2)-------
create view disManger with encryption as 
select Dept_Manager , Top_Name from Instructor i inner join Department d
on i.Ins_Id=d.Dept_Manager inner join  Ins_Course insC
on i.Ins_Id=insC.Ins_Id inner join Course c
on insC.Crs_Id=c.Crs_Id inner join Topic t
on c.Top_Id =t.Top_Id
select * from disManger
GO

-------(3)---------
create view disDepartmaent as
select Ins_Name, Dept_Name from Instructor i inner join Department d
on i.Dept_Id=d.Dept_Id and Dept_Name in('SD','Java')

select * from disDepartmaent
GO

-------(4)------
create view V1 as
select * from Student where St_Address in ('alex','cairo')
with check option
go
Update V1 set st_address='tanta'
Where st_address='alex'


--------(5)--------

use Company_SD
alter view projectEmployees as
select  p.Pname, count(w.ESSn) as [Num of Employees] from [Company].[Project] p inner join Works_for w
on p.Pnumber = w.Pno
group by p.Pname
select * from projectEmployees
go

--------(6)-----------
create schema Company 
alter schema company transfer departments
go
create schema [Human Resource]
alter schema [Human Resource] transfer Employee
go

----------(7)----------

create clustered index index1 on department(manager_hiredate) 
-- Error : because Cannot create more than one clustered index on table 'department'.

---------(8)--------
create unique index index2 on Student (St_Age)
-- Error: because a duplicate key was found for the object name 'dbo.Student'

-------(9)--------
use Company_SD

declare c1 Cursor
for select Salary
	from Employee
for update
declare @sal int
open c1
fetch c1 into @sal
while @@fetch_status=0
	begin
		if @sal<=3000
			update Employee
				set Salary=@sal*1.10
			where current of c1
		else 
			update Employee
				set Salary=@sal*1.20
			where current of c1
		fetch c1 into @sal
	end
close c1
deallocate c1

------(10)-------
use ITI
declare c cursor
for 
	select d.Dept_Name, i.Ins_Name from Department d inner join Instructor i
	on d.Dept_Manager = i.Ins_Id
for read only
declare @departmentName varchar(20), @mangerName varchar(20)
open c
fetch c into @departmentName, @mangerName
	while @@FETCH_STATUS = 0
	begin
		select @departmentName as depName ,@mangerName as mangerName
		fetch c into @departmentName, @mangerName
	end

close c
deallocate c

--------(11)----------
declare c1 cursor
for select distinct Ins_Name
	from Instructor
	where Ins_Name is not null
for read only

declare @name varchar(20),@all_names varchar(300)=''
open c1
fetch c1 into @name
while @@FETCH_STATUS=0
	begin
		set @all_names=concat(@all_names,',',@name)
		fetch c1 into @name    
	end
select @all_names
close c1
deallocate C1

