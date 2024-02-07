create or alter procedure dbo.CookbookGet
(
	@CookbookId int = 0, 
	@CookbookName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @CookbookName = nullif(@CookbookName, '') 

	select c.CookbookId, c.StaffId, c.CookbookName, c.Price, c.IsActive, c.DateCreated, c.PictureName
	from Cookbook c
	where c.CookbookId = @CookbookId
	or @All = 1
	or (@CookbookName <> '' and c.CookbookName like '%' + @CookbookName + '%')
end
go
exec CookbookGet

select * from Cookbook