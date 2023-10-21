
create procedure countStudent @Name varchar(20), @count_student int output
as begin
select @count_student = count(Name) from std_rec group by 
Name having name = @Name
end

declare @count int

exec countStudent 'A', @count output
select @count
