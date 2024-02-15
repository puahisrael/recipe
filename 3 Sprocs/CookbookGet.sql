create or alter procedure dbo.CookbookGet
(
	@CookbookId int = 0, 
	@CookbookName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @CookbookName = nullif(@CookbookName, '') 

	select c.CookbookId, c.CookbookName, [User] =concat(s.FirstName, ' ',s.LastName), /*NumRecipes = count(cr.RecipeId),*/ c.Price, Active = c.IsActive
	from Cookbook c 
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	join [User] s 
	on c.UserId = s.UserId
	where c.CookbookId = @CookbookId
	or @All = 1
	or (@CookbookName <> '' and c.CookbookName like '%' + @CookbookName + '%')
	group by c.CookbookId, c.CookbookName, s.FirstName, s.LastName, c.Price, c.IsActive
	order by c.CookBookName
end
go
exec CookbookGet @All = 1

select * from Cookbook