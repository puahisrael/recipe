create or alter proc dbo.DashboardGet
(
	@Message varchar(500) = ''
)
as
begin
	declare @return int = 0

	select [Type] = 'Recipes', Number = count(distinct r.RecipeId) from Recipe r join cookbookrecipe cr on cr.recipeid = r.recipeid where cr.cookbookid is not null
	union select [Type] = 'Meals', Number = count(distinct m.MealId) from Meal m
	union select [Type] = 'Cookbooks', Number = count(distinct c.CookbookId) from Cookbook c

	return @return
end
go 