Create database OrganizationStructure
----------------------1. execute-----------
use OrganizationStructure
----------------------2. execute-----------
create table Employee
(
Id int identity(1,1) primary key,
Title varchar(10),
FirstName varchar(20) not null,
LastName varchar(30) not null,
Phone varchar(15) not null,
Email varchar(30) not null,
)

create table Section
(
Id int identity(1,1) primary key,
Name varchar(30) not null,
Code varchar(15) not null,
DirectorID int foreign key references employee(id),
HierarchyLevel int not null,
ParentSectionID int default null foreign key references section(id)
)
----------------------3. execute-----------
alter table employee
add WorkAtID int foreign key references section(id)
----------------------4. execute-----------
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Jan','Hrach','421','jan@hrach.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Fero','Mak','421','fero@mak.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Juro','Yemiak','421','juro@yemiak.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Martin','Hus','421','m@hus.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Michal','Vlk','421','m@vlk.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Ing','Jan','Varech','421','jan@varecha.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Mgr','Jana','Mala','421','j@mala.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Mgr','Yita','Velka','421','yita@velka.sk')
insert into Employee (Title,FirstName,LastName,Phone,Email) values ('Mgr','Petra','Hneda','421','p@hneda.sk')

insert into Section(Name,Code,DirectorID,HierarchyLevel) values('Auto','a',1,0)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Koleso','aa',2,1,1)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Radio','ab',3,1,1)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Guma','aaa',4,2,2)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Reprak','aba',5,2,3)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Disk','aab',6,2,2)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('Antena','abb',7,2,3)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('šruba','aaba',8,3,6)
insert into Section(Name,Code,DirectorID,HierarchyLevel,ParentSectionID) values('kabel','abba',9,3,7)
----------------------5. execute-----------