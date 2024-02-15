create or alter procedure dbo.CookbookRecipeGet
(
	@CookbookRecipeId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @CookbookRecipeId = isnull(@CookbookRecipeId,0), @RecipeId = isnull(@RecipeId, 0)

	select r.RecipeId, r.RecipeSequence
	from CookbookRecipe r
	where CookbookRecipeId = @CookbookRecipeId
	or @All = 1
	or r.RecipeId = @RecipeId
	order by r.RecipeSequence

	return @return
end
go
/*
exec CookbookRecipeGet @All = 1

exec CookbookRecipeGet @RecipeId = 1


*/