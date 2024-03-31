create or alter proc dbo.RecipeClone
(
<<<<<<< HEAD
	@RecipeId int,
=======
--AS The only params you need are Recipeid and Message
	@RecipeId int output,
	@UserId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@DraftDate datetime ,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@Calories int,
>>>>>>> 770cecf8444e5900a59a45ecae03fc5c300bb59e
	@Message varchar(500) = '' output
)
as
--AS Declare a @NewRecipeId
begin
<<<<<<< HEAD

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
=======
--AS This sproc can be done simply by doing 3 insert statements. First insert into recipe with the correct values, then set @NewRecipeId = scope_identity().
--AS After insert into RecipeIngredient with the correct values and set RecipeId to @NewRecipeId and then do the same exact for RecipeDirection.

	insert 
		Recipe(UserId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
		values(@UserId, @CuisineId, @RecipeName, @DraftDate, @PublishedDate, @ArchivedDate, @Calories)
>>>>>>> 770cecf8444e5900a59a45ecae03fc5c300bb59e
	
end