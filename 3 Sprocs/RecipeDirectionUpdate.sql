create or alter proc dbo.RecipeDirectionUpdate
(
	@RecipeDirectionId int  output,
	@RecipeId int,
	@DirectionNum int ,
	@DirectionText varchar(100),
	@Message varchar(500) = ''  output
)


as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0)

	if @RecipeDirectionId = 0
	begin
		insert RecipeDirection(RecipeId, DirectionNum, DirectionText)
		values(@RecipeId, @DirectionNum, @DirectionText)

		select @RecipeDirectionId= scope_identity()
	end
	else
	begin
		update RecipeDirection
		set
			RecipeId = @RecipeId,
			DirectionNum = @DirectionNum,
			DirectionText = @DirectionText
		where RecipeDirectionId = @RecipeDirectionId
	end

	return @return
end
go