create database CMSDb
 
use CMSDb
 
create table Category
(Id int primary key,CourseCategory nvarchar(50) not null unique)

 create table Course
(Id int primary key,
Name nvarchar(50),
Fee float,
StartDate DateTime,
CategoryName int foreign key references Category(Id)
)


insert into Category values (1,'Tech')
insert into Category values (2,'MBA')
insert into Category values (3,'English')

insert into Course values(1,'Introduction To Programming',3000.90,'05/08/2023',1)
insert into Course values (2,'MBA Fundamentals',5000.90,'12/12/2022',2)
insert into Course values (3,'Englisg Grammer',2000.50,'02/11/2023',3)

select * from Course

 
  
 