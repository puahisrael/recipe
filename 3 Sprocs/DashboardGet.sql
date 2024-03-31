create or alter proc dbo.DashboardGet
(
	@Message varchar(500) = ''
)
as
begin
	declare @return int = 0
<<<<<<< HEAD

	select [Type] = 'Recipes', Number = count(r.RecipeId) from Recipe r
	union select 'Meals', Number = count( m.MealId) from Meal m
	union select 'Cookbooks', Number = count(c.CookbookId) from Cookbook c
=======
--AS Why are you doing this join, we just want to know the number of recipes.
--AS No need for all the distincts, there will never be multiple recipeid in the recipeid and same for the others.
--AS Tip: You only need write type and number in the first select statement, the others will get the column name automatically.
	select [Type] = 'Recipes', Number = count(distinct r.RecipeId) from Recipe r join cookbookrecipe cr on cr.recipeid = r.recipeid where cr.cookbookid is not null
	union select [Type] = 'Meals', Number = count(distinct m.MealId) from Meal m
	union select [Type] = 'Cookbooks', Number = count(distinct c.CookbookId) from Cookbook c
>>>>>>> 770cecf8444e5900a59a45ecae03fc5c300bb59e

	return @return
end
go 