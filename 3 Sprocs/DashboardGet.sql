create or alter proc dbo.DashboardGet
(
	@Message varchar(500) = ''
)
as
begin
	declare @return int = 0

	select [Type] = 'Recipes', Number = count(r.RecipeId) from Recipe r
	union select 'Meals', Number = count( m.MealId) from Meal m
	union select 'Cookbooks', Number = count(c.CookbookId) from Cookbook c

	return @return
end
go 