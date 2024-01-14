declare @recipeid int

select top 1 @recipeid = r.recipeid
from recipe r 
left join RecipeIngredient ri 
on ri.RecipeId = r.RecipeId
left join RecipeDirection rd
on rd.RecipeId = r.RecipeId
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where mcr.MealCourseRecipeId is null
and cr.CookbookRecipeId is null
order by r.RecipeId

select * from recipe r where r.recipeId = @recipeid

exec RecipeDelete @RecipeId = @recipeid

select * from recipe r where r.RecipeId = @recipeid
 