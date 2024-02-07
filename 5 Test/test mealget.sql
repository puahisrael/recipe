exec MealGet

exec MealGet @MealName = 's'

exec MealGet @All = 1

declare @MealId int

select top 1 @MealId = c.MealId from Meal c

exec MealGet @MealId = @MealId