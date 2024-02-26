exec CookbookRecipeGet

exec CookbookRecipeGet @All = 1

declare @CookbookId int

select top 1 @CookbookId = c.CookbookId from Cookbook c

exec CookbookRecipeGet @CookbookRecipeId = @CookbookId