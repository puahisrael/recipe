create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(50) = '', @All bit = 0)
as
begin
	select @RecipeName = nullif(@RecipeName, '') 

	select r.RecipeId, r.StaffId, r.CuisineId, r.RecipeName, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories,
		RecipeInfo = dbo.RecipeInfo(r.RecipeId)
	from Recipe r 
	where r.RecipeId = @RecipeId
	or @all = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
go
exec RecipeGet
