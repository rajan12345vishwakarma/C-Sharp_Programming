--Alter Database sample2 Modify Name = sample3;
--create database sample2;
--use sample2
--drop database sample1;
/*
create table Employee(
 ID int,
 Name varchar(25),
 Address varchar(50)
)
*/
--select * from Employee

--alter database sample3  Modify Name = StudentDB;
--alter database sample2 modify name = EmployeeDB;

--sp_rename 'Employee', 'Workers' --RENAME TABLE
--sp_renameDB 'StudentDB', 'PublicDB' -- RENAME DATABASE
--alter table workers add aadharno int
--alter table workers alter column aadharno int 
--sp_rename 'workers.aadharno', 'AadharID' -- RENAME COLUMN NAME
/*
insert workers values(
  2, 'Aman', 'Delhi', 999
)*/
