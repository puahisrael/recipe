create or alter proc dbo.RecipeClone
(
--AS The only params you need are Recipeid and Message
	@RecipeId int output,
	@UserId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@DraftDate datetime ,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@Calories int,
	@Message varchar(500) = '' output
)
as
--AS Declare a @NewRecipeId
begin
--AS This sproc can be done simply by doing 3 insert statements. First insert into recipe with the correct values, then set @NewRecipeId = scope_identity().
--AS After insert into RecipeIngredient with the correct values and set RecipeId to @NewRecipeId and then do the same exact for RecipeDirection.

	insert 
		Recipe(UserId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
		values(@UserId, @CuisineId, @RecipeName, @DraftDate, @PublishedDate, @ArchivedDate, @Calories)
	
	select @RecipeId = scope_identity()
end