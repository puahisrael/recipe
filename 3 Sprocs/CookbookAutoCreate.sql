create or alter proc dbo.CookbookAutoCreate
(
	@CookbookId int= null output,
	@MeasurementId int = 0,
	@CookbookName varchar(50) = '',
	@Price int = 0,
	@IsActive bit = true,
	@DateCreated datetime = ''

)
as
begin
	declare @return int = 0;

	insert Cookbook(MeasurementId, CookbookName, Price, IsActive, DateCreated)
	values(@MeasurementId, @CookbookName, @Price, @IsActive, @DateCreated)

	select @CookbookId = scope_identity();

	return @return
end
go

select * from cookbook