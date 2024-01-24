set nocount on
declare @recipeid int

select top 1 @recipeid = r.recipeid
from Recipe r
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
left join CookbookRecipe cr
on cr.RecipeId = r.RecipeId
where r.CurrentStatus = 'Published'
or getdate() -  r.ArchivedDate <= 30

select 'recipe', r.recipeid, r.RecipeName from recipe r where r.RecipeId = @recipeid
union select 'meal', mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on mc.MealId = m.MealId where mcr.RecipeId = @recipeid
union select 'cookbook', cr.CookbookRecipeId, c.CookbookName from CookbookRecipe cr join Cookbook c on cr.CookbookId = c.CookbookId where cr.RecipeId = @recipeid

declare @return int, @message varchar(500)
exec @return = RecipeDelete @RecipeId = @recipeid, @Message = @message output

select @return, @message

select 'recipe', r.recipeid, r.RecipeName from recipe r where r.RecipeId = @recipeid
union select 'meal', mcr.MealCourseRecipeId, m.MealName from MealCourseRecipe mcr join MealCourse mc on mcr.MealCourseId = mc.MealCourseId join Meal m on mc.MealId = m.MealId where mcr.RecipeId = @recipeid
union select 'cookbook', cr.CookbookRecipeId, c.CookbookName from CookbookRecipe cr join Cookbook c on cr.CookbookId = c.CookbookId where cr.RecipeId = @recipeid
