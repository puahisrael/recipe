--AS There is a where clause on @mealId but you didn't declare the variable anywhere so it crashes
create or alter function dbo.UsersRecipes(@UserId int)
returns int
as
begin
	declare @value int = 0

	select @value = sum(r.Calories)
	from Recipe r 
	join MealCourseRecipe mcr
	on mcr.RecipeId = r.RecipeId
	join MealCourse mc 
	on mc.MealCourseId = mcr.MealCourseId
	join Meal m 
	on m.MealId = mc.MealId
	where m.MealId = @MealId

	return @value
end
go 

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId), m.*
from Meal m
