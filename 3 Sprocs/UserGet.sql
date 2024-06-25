create or alter procedure dbo.UserGet
(
	@UserId int = 0, 
	@LastName varchar(30) = '', 
	@All bit = 0,
	@IncludeBlank bit = 0
)
as
begin
	select @LastName = nullif(@LastName, '') 

	select s.UserId, [User] = concat(s.FirstName, ' ', s.LastName), s.UserName 
	from [User] s 
	where s.UserId = @UserId
	or @all = 1
	union select 0, ' ', ' '
	where @IncludeBlank = 1
	order by [User]
	--or (@LastName <> '' and s.LastName like '%' + @LastName + '%')
end
go
exec UserGet @All = 1, @IncludeBlank = 1
