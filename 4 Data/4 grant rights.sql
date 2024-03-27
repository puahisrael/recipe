use HeartyHearthDB
go

--this just generates script:
--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on SportGet to approle
grant execute on SeasonUpdate to approle
grant execute on SeasonDelete to approle
grant execute on PresidentUpdate to approle
grant execute on PresidentSearch to approle
grant execute on OlympicMedalGet to approle
grant execute on RecipeDirectionUpdate to approle
grant execute on CourseDelete to approle
grant execute on MedalistGet to approle
grant execute on PartyGet to approle
grant execute on PresidentGet to approle
grant execute on RecipeGet to approle
grant execute on PresidentDelete to approle
grant execute on RecipeUpdate to approle
grant execute on CaloriesPerMeal to approle
grant execute on PresidentMedalGet to approle
grant execute on PresidentMedalDelete to approle
grant execute on SeasonGet to approle
grant execute on MealGet to approle
grant execute on OlympicsSummaryGet to approle
grant execute on DashboardGet to approle
grant execute on ExecutiveOrderGet to approle
grant execute on PresidentDesc to approle
grant execute on PartyDesc to approle
grant execute on SportUpdate to approle
grant execute on SportSubCategoryUpdate to approle
grant execute on SportSubCategoryGet to approle
grant execute on MedalUpdate to approle
grant execute on sp_MSrepl_startup to approle
grant execute on sp_MScleanupmergepublisher to approle