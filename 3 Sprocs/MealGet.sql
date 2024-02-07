create or alter procedure dbo.MealGet
(
	@MealId int = 0, 
	@MealName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @MealName = nullif(@MealName, '') 

	select m.MealId, m.StaffId, m.MealName, m.IsActive, m.DateCreated, m.PictureName
	from Meal m
	where m.MealId = @MealId
	or @All = 1
	or (@MealName <> '' and m.MealName like '%' + @MealName + '%')
end
go
exec MealGet
