create or alter procedure dbo.CookbookGet
(
	@CookbookId int = 0, 
	@CookbookName varchar(30) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin
	select @CookbookName = nullif(@CookbookName, '') 

	select c.CookbookId, c.UserId, c.CookbookName, [User] = concat(s.FirstName, ' ',s.LastName), c.DateCreated, /*NumRecipes = count(cr.RecipeId),*/ c.Price, c.IsActive
	from Cookbook c 
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	join [User] s 
	on c.UserId = s.UserId
	where c.CookbookId = @CookbookId
	or @All = 1
	or (@CookbookName <> '' and c.CookbookName like '%' + @CookbookName + '%')
	group by c.CookbookId, c.UserId, c.CookbookName, s.FirstName, s.LastName, c.DateCreated, c.Price, c.IsActive
	union select 0, 0, ' ', ' ', ' ', 0, 0
	where @IncludeBlank = 1
	order by c.CookbookName

end
go
exec CookbookGet @All = 1

select * from cookbook
