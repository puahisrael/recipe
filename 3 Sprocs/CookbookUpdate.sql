create or alter proc dbo.CookbookUpdate
(
	@CookbookId int output,
	@UserId int,
	@CookbookName varchar(50),
	@Price int,
	@IsActive bit,
	@DateCreated datetime,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @CookbookId = isnull(@CookbookId, 0)
		
	--begin
	--	goto finished
	--end

	if @CookbookId = 0
	begin
		insert Cookbook(UserId, CookbookName, Price, IsActive, DateCreated)
		values(@UserId, @CookbookName, @Price, @IsActive, @DateCreated)
	
		select @CookbookId = scope_identity()
	end
	else
	begin
		update Cookbook		
		set 
			UserId = @UserId, 
			CookbookName = @CookbookName,
			Price = @Price,
			IsActive = @IsActive,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end

	--finished:
	return @return
end
go