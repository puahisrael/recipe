exec CookbookGet

exec CookbookGet @CookbookName = 's'

exec CookbookGet @All = 1

declare @CookbookId int

select top 1 @CookbookId = c.CookbookId from Cookbook c

exec CookbookGet @CookbookId = @CookbookId