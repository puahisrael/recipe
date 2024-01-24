exec StaffGet

exec StaffGet @LastName = 't'

exec StaffGet @All = 1

declare @StaffId int

select top 1 @StaffId = r.StaffId from Staff r

exec StaffGet @StaffId = @StaffId
