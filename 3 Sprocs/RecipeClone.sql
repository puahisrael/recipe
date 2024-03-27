create or alter proc dbo.RecipeClone
(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin

--PI thanks - I was really overthinking this

	declare @NewRecipeId int

	insert Recipe(UserId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
	select UserId, CuisineId, concat(RecipeName, ' - clone'), getdate(), null, null, Calories
	from Recipe r
	where r.RecipeId = @RecipeId
	
	select @NewRecipeId = scope_identity()

	insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, IngredientSequence)
	select @NewRecipeId, IngredientId, MeasurementTypeId, Amount, IngredientSequence
	from RecipeIngredient
	where RecipeId = @RecipeId

	insert RecipeDirection(RecipeId, DirectionNum, DirectionText)
	select @NewRecipeId, DirectionNum, DirectionText
	from RecipeDirection
	where RecipeId = @RecipeId
	
end