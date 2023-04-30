use AdventureWorks2012
------(1)-------
Select SalesOrderID ,ShipDate from [Sales].[SalesOrderHeader]
where OrderDate  BETWEEN  '7/28/2002' and '7/29/2014'

-----(2)------
Select [ProductID],[Name] from [Production].[Product]
where [StandardCost] < 110.00 

-----(3)------
Select [ProductID],[Name] from [Production].[Product]
where weight is null

-----(4)-------
Select * from [Production].[Product]
where Color in('Silver','Black','Red ')

----(5)------
Select * from [Productio+n].[Product]
where [Name] like 'B%'

----(6)-----

--UPDATE Production.ProductDescription
--SET Description = 'Chromoly steel_High of defects'
--WHERE ProductDescriptionID = 3

select * from Production.ProductDescription where Description like '%[_]%'

----(7)------
Select sum (TotalDue )as [sum of TotalDue] from [Sales].[SalesOrderHeader]
where OrderDate  BETWEEN  '7/28/2002' and '7/29/2014'

----(8)-----
Select distinct HireDate from [HumanResources].[Employee]

----(9)----- 
select avg(ListPrice) from (select distinct listprice from Production.Product) as price

select avg(distinct ListPrice) from Production.Product

----(10)----

select 'The ['+ Name+'] is only! '+'['+ CONVERT(varchar(50),ListPrice)+']' as data from Production.Product 
where ListPrice between 100 and 120 order by ListPrice desc

----(11)-----
Select rowguid,Name,SalesPersonID,Demographics into [store_Archive 1]  from [Sales].[Store]
-- 701 rows affected
Select rowguid,Name,SalesPersonID,Demographics into [store_Archive 2]  from [Sales].[Store] where 1=2
-- 0 rows affected

----(12)----

select format(getdate(),'dd-MM-yy')
union
select format(getdate(), 'dddd, MMMM, yyyy')
union
select format(getdate(),'dd-MM-yy hh:mm:ss')
union
select format(getdate(), 'MMM dd yyyy')
