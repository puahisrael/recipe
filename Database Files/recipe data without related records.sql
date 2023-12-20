use heartyhearthDB
go 
;
with x as (
select FirstName = 'Tim', LastName = 'Jones', CuisineType = 'French', RecipeName = 'French Bread', DraftDate = '01/01/2000', PublishedDate = '01/01/2005', ArchivedDAte = '01/01/2010', Calories = 100
select 'Bob', 'Smith', 'American', 'Potato Soup', '01/01/2000', '02/04/2020', null, 150
union select 'Kate','Richardson','English','Cinnamon Buns', '01/01/2023', '02/01/2023', null, 200
)
insert Recipe(StaffId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
select s.StaffId, c.CuisineId, x.RecipeName, x.DraftDate, x.PublishedDate, x.ArchivedDate, x.Calories
from x 
join Staff s  
on s.FirstName = x.FirstName
and s.LastName = x.LastName
join Cuisine c  
on c.CuisineType = x.CuisineType