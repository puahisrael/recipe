create or alter proc dbo.UserUpdate
(
	@UserId int  output,
	@FirstName varchar(50),
	@LastName varchar(50),
	@UserName varchar(50),
	@Message varchar(500) = ''  output
)


as
begin
	declare @return int = 0

	select @UserId = isnull(@UserId,0)

	if @UserId = 0
	begin
		insert [User](FirstName, LastName, UserName)
		values(@FirstName, @LastName, @UserName)

		select @UserId= scope_identity()
	end
	else
	begin
		update [User]
		set
			FirstName = @FirstName,
			LastName = @LastName,
			UserName = @UserName
		where UserId = @UserId
	end

	return @return
end
go