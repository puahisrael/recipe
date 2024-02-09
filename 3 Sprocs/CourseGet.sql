create or alter procedure dbo.CourseGet
(
	@CourseId int = 0, 
	@CourseName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @CourseName = nullif(@CourseName, '') 

	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId
	or @all = 1
	--or (@CourseName <> '' and s.CourseName like '%' + @CourseName + '%')
end
go
exec CourseGet