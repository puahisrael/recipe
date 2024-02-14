create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId, 0)

	select r.RecipeIngredientId, r.RecipeId, r.IngredientId, r.MeasurementTypeId, r.Amount, r.IngredientSequence
	from RecipeIngredient r
	join Ingredient i
	on i.IngredientId = r.IngredientId
	left join MeasurementType m
	on m.MeasurementTypeId = r.MeasurementTypeId
	where RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or r.RecipeId = @RecipeId
	order by r.IngredientSequence

	return @return
end
go
/*
exec RecipeIngredientGet @All = 1

exec RecipeIngredientGet @RecipeId = 6


*/