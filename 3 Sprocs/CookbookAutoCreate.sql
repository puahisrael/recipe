create or alter proc dbo.CookbookAutoCreate
(
--AS The only params you need are UserId and Message
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
--AS The only thing you need to declare is a @NewCookbookId which you will use for your newly created cookbook. Take out all the other declarations.
declare @return int = 0
--maybe just declare variables after the exec and populate them with parameter values (the parameters would have been populated through the method)?
declare @UsersId int, @CookbooksId int, @CookbooksName varchar(50), @Prices int, @IsActives bit, @DatesCreated datetime

--AS This sproc can be done simply by doing 2 insert statements. First insert into cookbook with the correct values, then set @NewCookbookId = scope_identity().
--AS After insert into CookbookRecipe with the correct values and set CookbookId to @NewCookbookId.
;
with x as(
	select  FirstName, LastName, CookBookName = concat('Recipes by ', s.FirstName,' ',s.LastName), Price = 1.33 * count(cr.RecipeId), IsActive = 1, DateCreated = '03/26/2023'
	from [User] s 
	join Cookbook c 
	on s.UserId = c.UserId
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	where s.UserId = @UserId
	group by s.FirstName, s.LastName
)
--declare variables first, insert them into parameters in exec

select  @UsersId = s.UserId, @CookbooksName = x.CookBookName, @Prices = x.Price, @IsActives = x.IsActive, @DatesCreated = x.DateCreated
from x 
join [User] s
on x.FirstName = s.FirstName
and x.LastName = s.LastName
where s.UserId = @UserId

insert Cookbook(UserId, CookbookName, Price, IsActive, DateCreated)
values(@UserId, @CookbookName, @Price, @IsActive, @DateCreated)	

select @CookbookId = scope_identity()

;
--with x as(
--	select CookBookName = concat('Recipes by ',s.FirstName,' ',s.LastName), r.RecipeName, RecipeSequence = row_number() over(order by r.RecipeId)
--	from Recipe r 
--	join [User] s 
--	on r.UserId = s.UserId
--	where s.UserId = @UserId
--)
--insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
--select c.CookbookId, r.RecipeId, x.RecipeSequence
--from x 
--join Cookbook c 
--on x.CookBookName = c.CookbookName
--join Recipe r 
--on x.RecipeName = r.RecipeName

return @return

end

exec CookbookAutoCreate @CookbookId = @CookbooksId, @UserId = @UsersId, @CookbookName = @CookbooksName, @Price = @Prices, @IsActive = @IsActives, @DateCreated = @DatesCreated, @return = CookbookAutoCreate

select * from Cookbook