use ITI
----(1)-----
create function GetMonth(@date date)
  returns Varchar(30) 
	begin
	  declare @month varchar(30)
	  select @month = FORMAT(@date, 'MMMM')
	  return @month
	end

select dbo.GetMonth('3-2-2023')


-----(2)------

create function getNumbers(@x int, @y int)
 returns @t table
			(
			 number int
			)
  as
	begin
	 while @x < @y
	 begin
		 insert into @t values(@x)
		 set @x=@x+1
	 end 
		return

  end

select * from getNumbers(4,10)

-----(3)----
create function getStudent(@did int )
returns table 
   as return
   (
   select St_Fname +' '+ St_Lname as [full Name] ,Dept_Id 
   from Student
   where Dept_Id = @did
   )
   select * from getStudent(10)

------(4)-------
create function getStudentName(@sid int )
 returns Varchar(30) 
 begin 
  declare @fname Varchar(30) ,@lname Varchar(30),@txt Varchar(50)
  select @fname=St_Fname ,@lname =St_Lname from Student where St_Id = @sid
  if (@fname is null and @lname is null )
     set @txt = 'First name & last name are null'
  else if(@fname is null)
     set @txt = 'First name is null'
  else if(@lname is null)
     set @txt = 'Last name is null'
  else 
     set @txt = 'First name & last name are not null'
  return @txt
  end


select dbo.getStudentName(5)

-----(5)-----

Create function getMangerDate(@mgrID int)
   returns table
	as
	return
	(
	 select d.Dept_Name,i.Ins_Name,d.Manager_hiredate 
	 from Department d inner join Instructor i
	 on d.Dept_Manager = i.Ins_Id and i.Ins_Id = @mgrID
	)

	select * from getMangerDate(1)

-----(6)------
create function getStudName(@name varchar(20))
returns @t table 
(
	Student_Name varchar(50)
) as 
begin
	if(@name ='first name')
	begin
		insert into @t
		select isnull(St_Fname,'[no data]') from Student
	end
	else if(@name ='last name')
	begin
		insert into @t
		select isnull(St_Lname,'[no data]') from Student
	end
	else if(@name ='full name')
	begin
		insert into @t
		select isnull(St_Fname,'[no first name]')+' '+ isnull(St_Lname,'[no last name]') from Student
	end
	return
end

select * from getStudName('full name')

-------(7)---------

select [St_Id], substring (St_Fname,1,len(St_Fname)-1) from Student

-----(8)---------

delete from Stud_Course
where St_Id in (select s.St_Id from Department d inner join Student s 
on d.Dept_Id=s.Dept_Id and d.Dept_Name='SD')

------(9)-------
create table Last_Transaction(  
   userID int, 
   transaction_Amount int
   constraint c1 primary key( userID , transaction_Amount)
)
insert into Last_Transaction values(1,4000),(2,2000),(3,10000)
Select * from Last_Transaction

create table Daily_Transaction(
   userID int, 
   transaction_Amount int
   constraint c2 primary key( userID , transaction_Amount)
)
insert into Daily_Transaction values(1,1000),(2,2000),(3,1000)
Select * from Daily_Transaction



merge into Last_Transaction as T
using Daily_Transaction as S
on T.userID = s.userID
when matched then
update set T.transaction_Amount = s.transaction_Amount
when not matched then
insert values(s.UserID,s.transaction_Amount);

------(10)----------
create schema study

alter schema study transfer student
alter schema study transfer [Course]
alter schema dbo transfer study.Student
alter schema dbo transfer [study].[Course]
