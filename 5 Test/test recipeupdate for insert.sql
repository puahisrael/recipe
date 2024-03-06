declare @Message varchar(500) = '', @return int, @Measurementid int, @cuisineid int, @recipeid int

select top 1 @Measurementid = Measurementid from [Measurement]
select top 1 @cuisineid = cuisineid from Cuisine

exec @return = RecipeClone
	@RecipeId = @recipeid output,
	@MeasurementId = @Measurementid,
	@CuisineId = @cuisineid ,
	@RecipeName = 'food',
	@DraftDate = '1/1/2000' ,
	@PublishedDate = null ,
	@ArchivedDate = null ,
	@Calories = 123,
	@Message = @Message output

select @return, @Message, @recipeid

select * from recipe r where RecipeId = @recipeid

delete Recipe where RecipeId = @recipeid

--delete president where num = 48

select * from recipe

