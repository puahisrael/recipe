declare @Message varchar(500) = '', @return int, @staffid int, @cuisineid int, @recipeid int

select top 1 @staffid = staffid from Staff
select top 1 @cuisineid = cuisineid from Cuisine

exec @return = RecipeUpdate
	@RecipeId = @recipeid output,
	@StaffId = @staffid,
	@CuisineId = @cuisineid ,
	@RecipeName = 'food',
	@DraftDate = '1/1/2345' ,
	@PublishedDate = null ,
	@ArchivedDate = null ,
	@Calories = 123,
	@Message = @Message output

select @return, @Message, @recipeid

select * from recipe r where RecipeId = @recipeid

delete Recipe where RecipeId = @recipeid

--delete president where num = 48