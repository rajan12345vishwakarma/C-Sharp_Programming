-- stored procedure for create a table
create procedure create_table @tbl_name varchar(20)
as begin
declare @query varchar(max)
set @query = 'create table' + @tbl_name + '(
                  Id int, Name varchar(20), Age int
                )'
     exec(@query)
	end
	

	exec create_table '[dbo].[workerslnt]'

	select * from workerslnt


	insert into workerslnt values(1,'Hero',12)

  -- second method for create a new table
  
CREATE PROCEDURE [dbo].[Pcreate] @name varchar(20)
AS
BEGIN  
    CREATE TABLE [dbo].[@name]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
        [namefood] VARCHAR(50) NOT NULL, 
        [restaurantname] VARCHAR(50) NOT NULL, 
        [pricefood] FLOAT NOT NULL, 
        [address] VARCHAR(50) NOT NULL
    )
END

execute pcreate 'Rajan'
select * from [dbo].[@name]
insert into [dbo].[@name] values('Burger','Dhaba','110','Delhi')


-- create a procedure to update a table

create procedure updateEmployees 
@Id int, @FirstName varchar(50) = default, @LastName varchar(20) = default,
@Location varchar(20) = default, @Gender varchar(50) = default, @Salary int = default
as begin
update tbl_Employees 
set FirstName = @FirstName where @FirstName is not null and Id = @Id
update tbl_Employees
set LastName = @LastName where @LastName is not null and Id = @Id
update tbl_Employees
set Location = @Location where @Location is not null and Id = @Id
update tbl_Employees
set Gender = @Gender where @Gender is not null and Id = @Id
update tbl_Employees
set Salary = @Salary where @Salary is not null and Id = @Id
end

exec updateEmployees 2,null,'Singh','Sarojni Nagar','Male',null
select * from tbl_Employees

