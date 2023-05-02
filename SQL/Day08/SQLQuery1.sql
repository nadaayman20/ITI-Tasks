use ITI
-----(1)-------
alter Proc getStudentDept   
as
	select Dept_Name , count(s.St_Id)as [Num of students] 
	from student s inner join Department d
	on s.Dept_Id=d.Dept_Id
	group by Dept_Name

getStudentDept  

-----(2)--------
use Company_SD

alter proc numOfEmploye as
if((select count(w.essn)
	from Employee e inner join Works_for w
	on w.ESSn = e.SSN inner join Company.Project p
	on p.Pname = 'p1' and p.Pnumber = w.Pno)>=3)
	  select 'The number of employees in the project p1 is 3 or more'	
	else
		begin
			select 'The following employees work for the project p1 '+fname+' '+lname
			from Employee e inner join Works_for w
			on w.ESSn = e.SSN inner join Company.Project p
	      on p.Pname = 'p1' and p.Pnumber = w.Pno
		end
	
	numOfEmploye

----(3)----
use Company_SD
create proc removeEmployee @oldEmp int, @newEmp int, @Pnum int as
	update Works_for set ESSn = @newEmp
	where ESSn = @oldEmp and Pno = @Pnum

-----(4)-------
use [Company_SD]
create table Audit (
projectNo varchar(30),
UserName varchar(30),
ModifiedDate date,
Budget_Old int,
Budget_New int
)
insert into Audit values ('P2','Dbo','2008-01-31','95000','200000')

alter trigger t5 on [Company].[Project]
after update as
	if update(budjet)
	begin
		declare @pNum int, @oldBudget int, @newBudget int
		select @pNum=Pnumber, @newBudget=budjet from inserted
		select @pNum=Pnumber, @oldBudget=budjet from deleted
		insert into Audit values(@pNum,suser_name(),getdate(),@oldBudget,@newBudget)
	end

-----(5)-------
use ITI
create trigger t2 on department
instead of insert as
	select 'you can’t insert a new record in that table'

insert into Department(Dept_Id,Dept_Name) values (80,'DotNET')

-------(6)-------

use Company_SD

alter trigger t3 on [Human Resource].Employee
instead of insert as
	if format(getdate(),'MMMM') = 'march'
		select 'you can’t insert a new record in that table '
	
	
insert into [Human Resource].Employee(ssn) values (33332)

------(7)----------
use ITI
create table studentAudit(
serverUserName varchar(30),
Date date,
note varchar(100)
)
create trigger t4 on student
after insert as
	declare @id int
	select @id=St_Id from inserted
	insert into studentAudit values(suser_name(),getdate(),@id)

insert into Student (St_Id,St_Fname,St_Lname) values (17,'nada','ayman')

-----(8)-----
create trigger t5 on student
after delete as
	declare @id int
	select @id=St_Id from inserted
	insert into studentAudit values(suser_name(),getdate(),@id)

 delete from Student where St_Id=17

