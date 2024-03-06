create or alter procedure dbo.UserDelete(
	@UserId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UserId = isnull(@UserId,0)

	delete [User] where UserId = @UserId

	return @return
end
go
