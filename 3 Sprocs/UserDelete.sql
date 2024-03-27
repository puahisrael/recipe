create or alter procedure dbo.UserDelete(
	@UserId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UserId = isnull(@UserId,0)

	begin try
		begin tran

		delete cr 
from CookbookRecipe cr 
join Recipe r
on cr.RecipeId = r.RecipeId 
join [User] s 
on r.UserId = s.UserId
where s.UserId = @UserId

delete cr 
from CookbookRecipe cr 
join Cookbook c 
on cr.CookbookId = c.CookbookId
join [User] s 
on c.UserId = s.UserId
where s.UserId = @UserId

delete c
from Cookbook c 
join [User] s 
on c.UserId = s.UserId
where s.UserId = @UserId

 
delete mcr 
from MealCourseRecipe mcr 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join [User] s 
on r.UserId = s.UserId
where s.UserId = @UserId


delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc  
on mcr.MealCourseId = mc.MealCourseId
join meal m 
on mc.MealId = m.MealId
join [User] s 
on m.UserId = s.UserId
where s.UserId = @UserId


delete mc 
from MealCourse mc 
join Meal m 
on mc.MealId = m.MealId
join [User] s 
on m.UserId = s.UserId
where s.UserId = @UserId


delete m
from Meal m 
join [User] s 
on m.UserId = s.UserId
where s.UserId = @UserId


delete ri 
from RecipeIngredient ri 
join Recipe r 
on ri.RecipeId = r.RecipeId 
join [User] s 
on r.UserId = s.UserId
where s.UserId = @UserId


delete rd 
from RecipeDirection rd 
join Recipe r 
on rd.RecipeId = r.RecipeId
join [User] s 
on r.UserId = s.UserId
where s.UserId = @UserId


delete r 
from Recipe r 
join [User] s 
on r.UserId = s.UserId
where s.UserId = @UserId


delete s 
from [User] s
where s.UserId = @UserId


		
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	return @return
end
go
