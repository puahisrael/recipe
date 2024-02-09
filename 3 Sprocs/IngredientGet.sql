create or alter procedure dbo.IngredientGet
(
	@IngredientId int = 0, 
	@IngredientName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @IngredientName = nullif(@IngredientName, '') 

	select i.IngredientId, i.IngredientName, i.PictureName
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @all = 1
	--or (@IngredientName <> '' and s.IngredientName like '%' + @IngredientName + '%')
end
go
exec IngredientGet