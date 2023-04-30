create table instractors (
  id int primary key identity,
  fName varchar(20),
  lName varchar(20),
  birthdate  date,
  age as(year(getdate())-year(birthdate)),
  addreses varchar(20),
  hiredate date,
  overtime int ,
  salary int default 3000,
  NetSalary  as (isnull (salary,0)+ isnull(overtime,0)),

  constraint c1 check(salary>=1000 and salary <=3000),
  constraint c2 check (addreses in('Alex','Cairo')),
  constraint c3 unique (overtime )

)
create table courses (
  cid int primary key identity,
  cName varchar(20),
  duration int unique

)
create table labs (
  lid int primary key identity,
  Locations varchar(20),
  Capacity int unique,
  courseID int,
  constraint c4 primary key (lid , courseID),
  constraint c5 check(Capacity <= 20),
  constraint c6 foreign key(courseID) references course(cid) on delete cascade  on update cascade

)
create table instactor_coursse (
  ins_id int,
  course_id int

constraint c7 primary key (ins_id ,course_id),
constraint c8 foreign key(ins_id) references instractors(id) on delete cascade on update cascade,
constraint c9 foreign key(course_id) references courses(cid) on delete cascade on update cascade
)