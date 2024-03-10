create or alter procedure dbo.RecipeDirectionGet
(
	@RecipeDirectionId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeDirectionId = isnull(@RecipeDirectionId,0), @RecipeId = isnull(@RecipeId, 0)

	select --r.RecipeId, 
	r.DirectionText, r.DirectionNum
	from RecipeDirection r
	where RecipeDirectionId = @RecipeDirectionId
	or @All = 1
	or r.RecipeId = @RecipeId
	order by r.DirectionNum

	return @return
end
go
/*
exec RecipeIngredientGet @All = 1

exec RecipeIngredientGet @RecipeId = 6


*/