create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @CuisineType varchar(30) = '', @All bit = 0)
as
begin
	select @CuisineType = nullif(@CuisineType, '') 

	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @all = 1
	or (@CuisineType <> '' and c.CuisineType like '%' + @CuisineType + '%')
end
go
exec CuisineGet
