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
