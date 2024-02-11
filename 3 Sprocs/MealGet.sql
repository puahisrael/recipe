create or alter procedure dbo.MealGet
(
	@MealId int = 0, 
	@MealName varchar(30) = '', 
	@All bit = 0
)
as
begin
    declare @return int = 0

	select @MealName = isnull(@MealName, '') 
	
select m.MealId, m.MealName, s.FirstName, s.LastName, TotalCalories = sum(r.Calories), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(distinct r.RecipeId) 
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
--where m.IsActive = 1
where m.MealId = @MealId
or @All = 1
or (@MealName <> '' and m.MealName like '%' + @MealName + '%')
group by m.MealId, m.MealName, s.FirstName, s.LastName
order by m.MealName

	return @return

end
go
exec MealGet @All = 1

select * from mealcourse
