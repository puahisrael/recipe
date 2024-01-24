exec CuisineGet

exec CuisineGet @CuisineType = 's'

exec CuisineGet @All = 1

declare @CuisineId int

select top 1 @CuisineId = c.CuisineId from Cuisine c

exec CuisineGet @CuisineId = @CuisineId
