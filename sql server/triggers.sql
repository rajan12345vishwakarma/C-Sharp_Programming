create trigger tr_tbl_Employees
on tbl_Employees
after insert 
as begin
 select * from inserted
 end

 insert into tbl_Employees values(4, 'Sangam','Prajapati','Motipakar','Male',3500)

 create trigger tr_tbl_Deleted_Employees
 on tbl_Employees
 after delete
 as begin
 select * from deleted
 end

 create trigger tr_tbl_Update_Employees
 on tbl_Employees
 after update
 as begin
 select * from deleted
 select * from inserted
 end

 delete  from tbl_Employees where Id = 1

 create table audit_tbl_Employee
 (
   Id int primary key Identity,
   Info varchar(max)
 )

 create trigger insert_Audit_tbl_Employees
 on tbl_Employees
 after insert
 as begin
 declare @Id int 
 select @Id = id from inserted
 insert into audit_tbl_Employee
 values('The inserted entry of Id ' + cast(@Id as varchar(20)) + ' inserted at ' + cast(GETDATE() as varchar(20)))
 select * from inserted
 end

 create trigger delete_Audit_tbl_Employees
 on tbl_Employees
 after delete
 as begin
 declare @Id int 
 select @Id = id from deleted
 insert into audit_tbl_Employee
 values('The deleted entry of Id ' + cast(@Id as varchar(20)) + ' inserted at ' + cast(GETDATE() as varchar(20)))
 select * from deleted
 end

 select * from audit_tbl_Employee
 select * from tbl_Employees
