-- SM Excellent! 100% See comments, no need to resubmit.
use HeartyHearthDB
go 

--1) Sometimes when a staff member is fired. We need to eradicate everything from that User in our system. Write the SQL to delete a specific User and all the User's related records.
delete cr 
from CookbookRecipe cr 
join Recipe r
on cr.RecipeId = r.RecipeId 
join Staff s 
on r.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete cr 
from CookbookRecipe cr 
join Cookbook c 
on cr.CookbookId = c.CookbookId
join Staff s 
on c.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete c
from Cookbook c 
join Staff s 
on c.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'
 
delete mcr 
from MealCourseRecipe mcr 
join Recipe r 
on mcr.RecipeId = r.RecipeId
join Staff s 
on r.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete mcr 
from MealCourseRecipe mcr 
join MealCourse mc  
on mcr.MealCourseId = mc.MealCourseId
join meal m 
on mc.MealId = m.MealId
join Staff s 
on m.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete mc 
from MealCourse mc 
join Meal m 
on mc.MealId = m.MealId
join Staff s 
on m.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete m
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete ri 
from RecipeIngredient ri 
join Recipe r 
on ri.RecipeId = r.RecipeId 
join Staff s 
on r.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete rd 
from RecipeDirection rd 
join Recipe r 
on rd.RecipeId = r.RecipeId
join Staff s 
on r.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete r 
from Recipe r 
join Staff s 
on r.StaffId = s.StaffId
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

delete s 
from Staff s
where s.FirstName = 'Bob'
and s.LastName = 'Smith'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(MeasurementId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
select r.MeasurementId, r.CuisineId, RecipeName = concat(r.RecipeName,' - clone'), r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories
from Recipe r 
where r.RecipeName = 'French Roast'
;
-- SM You forgot to change this to left join.
with x as(
	select RecipeName = 'French Roast - clone', IngredientName = 'French Roast', MeasurementTypeName = null, Amount = 1, IngredientSequence = 1
    union select 'French Roast - clone', 'Cranberry Sauce', 'Ounces', 8, 2
    union select 'French Roast - clone', 'Onion Soup Mix', 'Tbsp', 6, 3
    union select 'French Roast - clone', 'Water', 'Cup', 5, 4
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementTypeId, Amount, IngredientSequence)
select r.RecipeId, i.IngredientId, m.MeasurementTypeId, x.Amount, x.IngredientSequence
from x 
join Recipe r                                                                                                                                                                     
on r.RecipeName = x.RecipeName
join Ingredient i 
on i.IngredientName = x.IngredientName
left join MeasurementType m 
on m.MeasurementTypeName = x.MeasurementTypeName
;
with x as(
	select RecipeName = 'French Roast - clone', DirectionNum = 1, DirectionText = 'Rub roast with sauce and soup mix'
    union select RecipeName = 'French Roast - clone', DirectionNum = 2, DirectionText = 'Put in pan with water'
    union select RecipeName = 'French Roast - clone', DirectionNum = 3, DirectionText = 'Bake at 350 for 2 hours'
)
insert RecipeDirection(RecipeId, DirectionNum, DirectionText)
select r.RecipeId, x.DirectionNum, x.DirectionText
from x 
join Recipe r 
on r.RecipeName = x.RecipeName
/*
3) We offer Users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific Users and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as(
	select FirstName, LastName, CookBookName = concat('Recipes by ',s.FirstName,' ',s.LastName), Price = 1.33 * count(cr.RecipeId), IsActive = 1, DateCreated = '03/26/2023'
	from Staff s 
	join Cookbook c 
	on s.StaffId = c.StaffId
	join CookbookRecipe cr 
	on c.CookbookId = cr.CookbookId
	where s.FirstName = 'Bob'
	and s.LastName = 'Smith'
	group by s.FirstName, s.LastName
)
insert Cookbook(StaffId, CookbookName, Price, IsActive, DateCreated)
select s.StaffId, x.CookBookName, x.Price, x.IsActive, x.DateCreated
from x 
join Staff s
on x.FirstName = s.FirstName
and x.LastName = s.LastName
;
with x as(
	select CookBookName = concat('Recipes by ',s.FirstName,' ',s.LastName), r.RecipeName, RecipeSequence = row_number() over(order by r.RecipeId)
	from Recipe r 
	join Staff s 
	on r.StaffId = s.StaffId
	where s.FirstName = 'Bob'
	and s.LastName = 'Smith'
)
insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
select c.CookbookId, r.RecipeId, x.RecipeSequence
from x 
join Cookbook c 
on x.CookBookName = c.CookbookName
join Recipe r 
on x.RecipeName = r.RecipeName

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set r.Calories = 
	case m.MeasurementTypeName
		when 'ounces' then r.Calories - 2
		when 'stick' then r.Calories - 10
		else r.Calories
	end  
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Ingredient i 
on i.IngredientId = ri.IngredientId
join MeasurementType m
on ri.MeasurementTypeId = m.MeasurementTypeId
where r.RecipeName = 'Butter Muffins'
and i.IngredientName = 'Butter'

/*
5) We need to send out alerts to Measurements that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	Measurement First Name, 
	Measurement Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
-- SM Use CTE to get avg. I believe the group by changes results.
-- PI I don't know if this changed anything...I don't know if this is even what you meant...
-- SM Getting there. But in CTE you only need the avg() of all recipes not per recipe. And on your joins you are joining on the recipe name when it's null so you don't get returned right data.
-- You need to join on the condition you want (that it's > than avg).
-- PI I guess I don't have any data that would work for this but if the 'draft' condition is commented out I think it produces a proper result set...
-- And I didn't realize you could join on a non-equal condition like that but it does make sense sort of...

-- SM You have 2 issues here: 1) your "on" and "and" don't make sense, you're doing the opposite. 2) You have an issue with datediff() (not in CTE) you're chcking on difference between DraftDate and PublishedDate but you're selecting those not published yet.
-- You need to use getdate().
;
with x as(
	select AvgDaysUntilPublished = avg(datediff(day,r.DraftDate,r.PublishedDate))
	from recipe r  
)
select s.FirstName, s.LastName, EmailAddress = concat(lower(substring(s.FirstName,1,1)),lower(s.LastName),'@heartyhearth.com'), Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', datediff(hour,r.DraftDate,getdate()),' hours. That is ',datediff(hour,r.DraftDate,getdate()) - x.AvgDaysUntilPublished, ' hours more than the average ', x.AvgDaysUntilPublished,' hours all other recipes took to be published.')
from x
join Recipe r 
on x.AvgDaysUntilPublished < datediff(day,r.DraftDate,r.PublishedDate)
join Staff s 
on s.StaffId = r.StaffId
where r.CurrentStatus = 'Draft' 
and datediff(day,r.DraftDate,getdate()) > x.AvgDaysUntilPublished

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ',count(c.CookbookId),' books for sale, average price is ',substring(convert(varchar,avg(c.Price)),1,5),'. You can order them all and recieve a 25% discount, for a total of ',substring(convert(varchar,.75 * sum(price)),1,5),'. Click <a href = "www.heartyhearth.com/order/', newid(),' ">here</a> to order.')
from Cookbook c 