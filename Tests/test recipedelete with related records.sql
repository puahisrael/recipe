declare @recipeid int

select top 1 @recipeid = r.recipeId
from recipe r 
join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
order by r.RecipeId

select * from recipe r where r.RecipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid

select * from Recipe r where r.RecipeId = @recipeid
 