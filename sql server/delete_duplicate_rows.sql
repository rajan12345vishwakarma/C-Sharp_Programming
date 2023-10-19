
-- it will delete duplicate duplicate rows from a table

 delete from std_rec 
 where Id not in(select min(Id) from std_rec group by Name)
