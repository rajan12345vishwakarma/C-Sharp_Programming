CREATE PROCEDURE CREATE_TABLE @TblName varchar(50)
as begin
declare @query varchar(max)
set @query = 'create table' + @TblName + '(Id int identity(100,1)
  Name varchar(20),
  Email varchar(20),
  City varchar(20),
  Pincode int)'
  execute(@query)
  end
  execute CREATE_TABLE 'NewTable'
  
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
