create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(50) = '', @All bit = 0)
as
begin
	select r.RecipeId, r.RecipeName, r.CurrentStatus, UserName = concat(s.FirstName, ' ', s.LastName), r.Calories, NumIngredients = count(ri.IngredientId)
	from Recipe r 
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	join Staff s 
	on r.StaffId = s.StaffId
	where r.RecipeId = @RecipeId
	or @all = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	group by r.RecipeId, r.RecipeName, r.CurrentStatus, r.PublishedDate, r.ArchivedDate, s.FirstName, s.LastName, r.Calories
	order by r.CurrentStatus desc
end
go
exec RecipeGet @All = 1
