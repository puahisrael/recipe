create or alter function dbo.CaloriesPerMeal(@MealId int)
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
	--Af No need to group by mealid, you are already only selecting the meal records that equal @MealId
	group by m.MealId

	return @value
end
go 

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId), m.*
from Meal m
