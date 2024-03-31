create or alter proc dbo.RecipeUpdate
(
	@RecipeId int output,
	@UserId int,
	@CuisineId int,
	@RecipeName varchar (50),
	@DraftDate datetime output,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	--@CurrentStatus varchar(20) = '',
	@Calories int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId, 0)

	if @RecipeId = 0
	begin
		insert Recipe(UserId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
		values(@UserId, @CuisineId, @RecipeName, getdate(), null, null, @Calories)
	
		select @RecipeId = scope_identity()
	end
	else
	begin
		update recipe			
		set 
			UserId = @UserId, 
			CuisineId = @CuisineId, 
			RecipeName = @RecipeName, 
			DraftDate = @DraftDate, 
			PublishedDate = @PublishedDate, 
			ArchivedDate = @ArchivedDate, 
			Calories = @Calories
		where RecipeId = @RecipeId
	end
	return @return
end
go

select * from recipe
