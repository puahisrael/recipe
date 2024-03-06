create or alter proc dbo.RecipeClone
(
	@RecipeId int output,
	@MeasurementId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@DraftDate datetime ,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@Calories int,
	@Message varchar(500) = '' output
)
as
begin
	insert 
		Recipe(MeasurementId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
		values(@MeasurementId, @CuisineId, @RecipeName, @DraftDate, @PublishedDate, @ArchivedDate, @Calories)
	
	select @RecipeId = scope_identity()
end