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
  CREATE PROCEDURE [dbo].[Pcreate]
    @name VARCHAR(50),
    @namefood VARCHAR(50),
    @restaurantname VARCHAR(50),
    @pricefood FLOAT,
    @address VARCHAR(50)
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

execute pcreate 'Rajan','Dahi','dhaba',120,'Meerut'
select * from [dbo].[@name]
