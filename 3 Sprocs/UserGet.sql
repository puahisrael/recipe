create or alter procedure dbo.UserGet
(
	@StaffId int = 0, 
	@LastName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @LastName = nullif(@LastName, '') 

	select s.StaffId, s.FirstName, s.LastName, s.UserName 
	from Staff s 
	where s.StaffId = @StaffId
	or @all = 1
	--or (@LastName <> '' and s.LastName like '%' + @LastName + '%')
end
go
exec UserGet
