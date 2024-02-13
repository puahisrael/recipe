create or alter procedure dbo.CookbookGet
(
	@CookbookId int = 0, 
	@CookbookName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @CookbookName = nullif(@CookbookName, '') 

	select c.CookbookId, c.CookbookName, UserName =concat(s.FirstName, ' ',s.LastName), NumRecipes = count(cr.RecipeId), c.Price
	from Cookbook c 
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	join Staff s 
	on c.StaffId = s.StaffId
	--where c.IsActive = 1
	where c.CookbookId = @CookbookId
	or @All = 1
	or (@CookbookName <> '' and c.CookbookName like '%' + @CookbookName + '%')
	group by c.CookbookId, c.CookbookName, s.FirstName, s.LastName, c.Price
	order by c.CookBookName
end
go
exec CookbookGet @All = 1

select * from Cookbook