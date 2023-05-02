use [Company_SD]
alter table[Human Resource].[Employee]  add job_type varchar(50)
alter table [Human Resource].[Employee] add Hire_Date date
alter table company.project add budjet int 

----(1)----
create view V_clerk
as
	select count(e.SSN) as [Num Of Employee] , COUNT(p.Pnumber) as [Num Of projects]  , e.Hire_Date
	from [Human Resource].[Employee] e inner join Works_for w
	on w.ESSn=e.SSN and e.job_type='clerk'
	inner join company.Project p
	on w.Pno=p.Pnumber
	group by e.job_type , e.Hire_Date

select * from V_clerk

----(2)----
create view V_without_budjet
as
	select * from Company.Project p
	where p.budjet is NULL

select * from V_without_budjet

-----(3)-----
create view v_count as
select pname, COUNT(w.pno)as[no. OF jobs] from [Company].[Project] INNER JOIN Works_for w
on w.Pno = Pnumber
group by pname
select * from v_count;
 
GO
-----(4)----

alter view v_project_p2
as
	select distinct p.Pname , v.[Num Of Employee]
	from V_clerk v ,Company.Project p where Pname ='p2'

select * from v_project_p2

-----(5)-------
alter view V_without_budjet as
select Pname,Pnumber,Plocation,City,Dnum from Company.Project where Pname IN ('p1','p2')

------(6)-----
drop view V_clerk,V_count

----(7)-----
