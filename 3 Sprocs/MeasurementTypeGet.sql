create or alter procedure dbo.MeasurementTypeGet
(
	@MeasurementTypeId int = 0, 
	@MeasurementTypeName varchar(30) = '', 
	@All bit = 0
)
as
begin
	select @MeasurementTypeName = nullif(@MeasurementTypeName, '') 

	select m.MeasurementTypeId, m.MeasurementTypeName
	from MeasurementType m
	where m.MeasurementTypeId = @MeasurementTypeId
	or @All = 1
	or (@MeasurementTypeName <> '' and m.MeasurementTypeName like '%' + @MeasurementTypeName + '%')
end
go
exec MeasurementTypeGet