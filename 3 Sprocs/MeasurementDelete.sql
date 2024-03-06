create or alter procedure dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0)

	delete MeasurementId where MeasurementId = @MeasurementId

	return @return
end
go
