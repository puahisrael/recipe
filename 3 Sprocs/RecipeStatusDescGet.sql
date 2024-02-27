create or alter proc dbo.RecipeStatusDescGet
(
	@RecipeId int = 0
)
as
begin
	select  
		r.CurrentStatus,
		r.DraftDate, r.PublishedDate, r.ArchivedDate
	from Recipe r
end

select * from recipe