create or alter procedure dbo.RecipeGet
(
	@RecipeId int = 0, 
	@RecipeName varchar(50) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin
	select @RecipeName = isnull(@RecipeName, '')

	select r.RecipeId, r.UserId, r.CuisineId, r.RecipeName, c.CuisineType, r.CurrentStatus, r.DraftDate,  r.PublishedDate, r.ArchivedDate, [User] = concat(s.FirstName, ' ', s.LastName), Calories = r.Calories, NumIngredients = count(ri.IngredientId)
	from Recipe r 
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	join [User] s 
	on r.UserId = s.UserId
	join Cuisine c
	on c.CuisineId = r.CuisineId
	where r.RecipeId = @RecipeId
	or @all = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	group by r.RecipeId, r.UserId, r.CuisineId, r.RecipeName, c.CuisineType, r.CurrentStatus, r.DraftDate, r.PublishedDate, r.ArchivedDate, s.FirstName, s.LastName, r.Calories
	union select 0, 0, 0, ' ', ' ', ' ', ' ', ' ', ' ', ' ', 0, 0
	where @IncludeBlank = 1
	order by r.RecipeName
end
go
exec RecipeGet @All = 1, @IncludeBlank = 1
