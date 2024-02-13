create or alter proc dbo.DashboardGet
(
	@Message varchar(500) = ''
)
as
begin
	declare @return int = 0

	select NumRecipes = count(distinct r.RecipeId), NumMeals = count(distinct m.MealId), NumCookbooks = count(distinct c.CookbookId)
	from Recipe r 
	cross join Meal m 
	cross join Cookbook c  

	return @return
end
go 