create or alter proc dbo.RecipeChangeStatus
(
	@RecipeId int,
	@DraftDate datetime,
	@PublishedDate datetime,
	@ArchivedDate datetime,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0
	select @RecipeId = isnull(@RecipeId, 0)
	select @DraftDate = nullif(@DraftDate, '')
	select @PublishedDate = nullif(@PublishedDate, '')
	select @ArchivedDate = nullif(@ArchivedDate, '')
	update Recipe			
		set 
			UserId = UserId, 
			CuisineId = CuisineId, 
			RecipeName = RecipeName, 
			DraftDate = @DraftDate, 
			PublishedDate = @PublishedDate, 
			ArchivedDate = @ArchivedDate, 
			Calories = Calories
		where RecipeId = @RecipeId
	return @return
end
go

declare @date datetime = getdate()
exec RecipeChangeStatus 
	@RecipeId = 1, 
	@DraftDate = @date, 
	@PublishedDate = null, 
	@ArchivedDate = @date
select * from recipe where recipeid = 1
--figure out how to pass in getdate() to parameters in .net...