create table Employee(
Id int identity,
Name varchar(30),
Email varchar(30),
Address varchar(30)
)
set identity_insert Employee on        -- it allows to insert data of any index in table
  
insert into Employee         -- it is not necessary to give fields name to insert data
values ('vikas', 'vikas@gmail.com', null )
  
insert into Employee (Id, Name, Email, Address)
values (1,'vikas', 'vikas@gmail.com', null )
  
delete from Employee where Id in (1,6)

delete from Employee where Id = 1
  
delete from Employee where Address is null
  
set IDENTITY_INSERT Employee off   -- it prvents to insert data of any index
  
select * from Employee
