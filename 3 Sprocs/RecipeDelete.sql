create or alter procedure dbo.RecipeDelete
(
	@RecipeId int,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	if exists(select * from Recipe r where r.RecipeId = @RecipeId and (r.CurrentStatus = 'Published' or datediff(day, r.ArchivedDate, getdate()) <=30))
	begin
		select @return = 1, @Message = 'Cannot delete recipe unless it is drafted or is archived for over 30 days.'
		goto finished
	end
	
	begin try
		begin tran

	delete cr 
	from CookbookRecipe cr 
	join Recipe r
	on cr.RecipeId = r.RecipeId 
	join [User] s 
	on r.UserId = s.UserId
	where r.RecipeId = @RecipeId
	 
	delete mcr 
	from MealCourseRecipe mcr 
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	join [User] s 
	on r.UserId = s.UserId
	where r.RecipeId = @RecipeId
	
	delete ri 
	from RecipeIngredient ri 
	join Recipe r 
	on ri.RecipeId = r.RecipeId 
	join [User] s 
	on r.UserId = s.UserId
	where r.RecipeId = @RecipeId
	
	delete rd 
	from RecipeDirection rd 
	join Recipe r 
	on rd.RecipeId = r.RecipeId
	join [User] s 
	on r.UserId = s.UserId
	where r.RecipeId = @RecipeId
	
	delete r 
	from Recipe r 
	join [User] s 
	on r.UserId = s.UserId
	where r.RecipeId = @RecipeId
		
		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go 