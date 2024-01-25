--AF If you look at the results, this function is not working properly to get the count of ingredients and steps.  Since you are joing to both recipeingredient and
-- recipedirection, there their records are being returned more than once (you need to select the distinct count of each)
create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(200)
as
begin
	declare @value varchar(200) = ''

	select @value = concat(r.RecipeName, ' (', c.CuisineType,') has ', 
			count(distinct ri.IngredientId), ' ingredients and ', 
			count(distinct rd.DirectionNum), ' steps.')
	from Recipe r
	join Cuisine c
	on c.CuisineId = r.CuisineId
	join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	join RecipeDirection rd
	on rd.RecipeId = r.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName, c.CuisineType

	return @value
end
go 

select RecipeInfo = dbo.RecipeInfo(r.RecipeId), r.*
from Recipe r