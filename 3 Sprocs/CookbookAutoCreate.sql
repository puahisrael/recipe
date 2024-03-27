create or alter proc dbo.CookbookAutoCreate
(
	@UserId int,
	@Message varchar(500) = '' output
)
as
begin
--AS The only thing you need to declare is a @NewCookbookId which you will use for your newly created cookbook. Take out all the other declarations.
declare @NewCookbookId int

--AS This sproc can be done simply by doing 2 insert statements. First insert into cookbook with the correct values, then set @NewCookbookId = scope_identity().
--AS After insert into CookbookRecipe with the correct values and set CookbookId to @NewCookbookId.
;
with x as(
	select  FirstName, LastName, CookBookName = concat('Recipes by ', s.FirstName,' ',s.LastName), Price = 1.33 * count(cr.RecipeId), IsActive = 1, DateCreated = GETDATE()
	from [User] s 
	join Cookbook c 
	on s.UserId = c.UserId
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	where s.UserId = @UserId
	group by s.FirstName, s.LastName
)
insert Cookbook(UserId, CookbookName, Price, IsActive, DateCreated)
select @UserId, x.CookbookName, x.Price, x.IsActive, x.DateCreated
from x 
join [User] s
on x.FirstName = s.FirstName
and x.LastName = s.LastName

select @NewCookbookId = scope_identity();

insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
select  @NewCookbookId, r.RecipeId, row_number() over(order by r.RecipeId) 
from Recipe r
where r.UserId = @UserId
-- figure out how to make sure only that users recipes get included into cookbook
end
go

exec CookbookAutoCreate @UserId = 2
select * from cookbook

select * from CookbookRecipe 
where CookbookId = 6
