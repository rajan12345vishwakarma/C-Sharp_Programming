-- delete trigger

create trigger tr_tbl_Deleted_Employees
 on tbl_Employees
 after delete
 as begin
 select * from deleted
 end

-- insert trigger
  
create trigger tr_tbl_Employees
on tbl_Employees
after insert 
as begin
 select * from inserted
 end
