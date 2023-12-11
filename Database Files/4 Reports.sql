-- SM Excellent! 100% See my comment at Meal details page:
use HeartyHearthDB
go  

-- Home Page
    -- One resultset with number of recipes, meals, and cookbooks
select NumRecipes = count(distinct r.RecipeId), NumMeals = count(distinct m.MealId), NumCookbooks = count(distinct c.CookbookId)
from Recipe r 
cross join Meal m 
cross join Cookbook c  

-- Recipe list page:
    -- List of all Recipes that are either published or archived, published recipes should appear at the top. 
    -- In the resultset show the Recipe name with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
	-- The recipe names of archived recipes should be displayed in gray on the website. In order to do that, the recipe names of archived recipes should be prefixed with <span style="color:gray"> and followed with </span>
	-- Ex: Recipe name of archived Chocolate Chip Cookies should be <span style="color:gray">Chocolate Chip Cookies</span>

select RecipeName = 
    case r.CurrentStatus 
        when 'Archived' 
        then concat('<span style="color:gray">',r.RecipeName,'</span>') 
        else r.RecipeName 
    end,
r.CurrentStatus, PublishedDate = isnull(convert(varchar,r.PublishedDate),''), ArchivedDate = isnull(convert(varchar,r.ArchivedDate),''), s.FirstName, s.LastName, r.Calories, NumIngredients = count(ri.IngredientId)
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join Staff s 
on r.StaffId = s.StaffId
where r.CurrentStatus in ('Published', 'Archived')
group by r.RecipeName, r.CurrentStatus, r.PublishedDate, r.ArchivedDate, s.FirstName, s.LastName, r.Calories
order by r.CurrentStatus desc 

-- Recipe details page:
    -- Show for a specific recipe (three result sets):
        -- a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
select r.RecipeName, r.Calories, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct rd.RecipeDirectionId), r.PictureName 
from Recipe r 
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.Calories, r.PictureName
        -- b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
select ri.IngredientSequence, MeasurementTypeIngredient = concat(ri.Amount,' ', m.MeasurementTypeName,' ',i.IngredientName)
from Recipe r 
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId 
join Ingredient i 
on ri.IngredientId = i.IngredientId
left join MeasurementType m 
on ri.MeasurementTypeId = m.MeasurementTypeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence
        -- c) List of prep steps sorted by sequence.
select rd.DirectionNum, rd.DirectionText
from Recipe r 
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by rd.DirectionNum

--Meal list page:
    -- All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal

select m.MealName, s.FirstName, s.LastName, TotalCalories = sum(r.Calories), NumCourses = count(distinct mc.MealCourseId), NumRecipes = count(distinct r.RecipeId) 
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
join MealCourse mc 
on m.MealId = mc.MealId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r
on mcr.RecipeId = r.RecipeId
where m.IsActive = 1
group by m.MealName, s.FirstName, s.LastName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, s.FirstName, s.LastName, m.DateCreated 
from Meal m 
join Staff s 
on m.StaffId = s.StaffId
where m.MealName = 'Dinner Delight'


-- See the more concise way
-- select ListOfRecipes = concat(
--     case when c.CourseName = 'Main course' and mcr.IsMainDish = 1 then '<b>' end,
--     c.CourseName,
--     ': ',
--     case c.CourseName when 'Main Course' then case mcr.IsMainDish when 1 then 'Main' else 'Side' end + ' - dish ' end,
--     r.RecipeName,
--     case when c.CourseName = 'Main Course' and mcr.IsMainDish = 1 '</b>' end
-- ) 
-- from Meal m 
-- join MealCourse mc 
-- on m.MealId = mc.MealId
-- join Course c 
-- on mc.CourseId = c.CourseId
-- join MealCourseRecipe mcr 
-- on mc.MealCourseId = mcr.MealCourseId
-- join Recipe r 
-- on mcr.RecipeId = r.RecipeId
-- where m.MealName = 'Dinner Delight'

select ListOfRecipes = concat(
    case c.CourseName 
        when 'Main course'
        then 
            case mcr.IsMainDish 
                when 1 then '<b>' 
                else '' 
            end
        else ''
    end,
    c.CourseName,': ',
    case c.CourseName 
        when 'Main Course' 
        then 
            case mcr.IsMainDish 
                when 1 then 'Main dish - ' 
                else 'Side dish - ' 
            end 
        else '' 
    end,
r.RecipeName,
    case c.CourseName
        when 'Main Course' 
        then 
            case mcr.IsMainDish
                when 1 then '</b>' 
                else '' 
            end
        else ''
    end
) 
from Meal m 
join MealCourse mc 
on m.MealId = mc.MealId
join Course c 
on mc.CourseId = c.CourseId
join MealCourseRecipe mcr 
on mc.MealCourseId = mcr.MealCourseId
join Recipe r 
on mcr.RecipeId = r.RecipeId
where m.MealName = 'Dinner Delight'

-- Cookbook list page:
    -- Show all active cookbooks with author and number of recipes per book. Sorted by book name.
select c.CookbookName, s.FirstName, s.LastName, NumRecipes = count(cr.RecipeId)
from Cookbook c 
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
join Staff s 
on c.StaffId = s.StaffId
where c.IsActive = 1
group by c.CookbookName, s.FirstName, s.LastName
order by c.CookBookName

-- Cookbook details page:
    -- Show for specific cookbook:
    -- a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    -- b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
select c.CookbookName, s.FirstName, s.LastName, c.DateCreated, c.Price, NumRecipes = count(cr.RecipeId)
from Cookbook c 
join Staff s
on c.StaffId = s.StaffId
join CookbookRecipe cr 
on c.CookbookId = cr.CookbookId
where c.CookbookName = 'Treats for Two'
group by c.CookbookName, s.FirstName, s.LastName, c.DateCreated, c.Price


select r.RecipeName, c.CuisineType, NumIngredients = count(distinct ri.IngredientId), NumSteps = count(distinct rd.RecipeDirectionId)
from Cuisine c  
join Recipe r  
on r.CuisineId = c.CuisineId
join RecipeIngredient ri 
on r.RecipeId = ri.RecipeId 
join RecipeDirection rd 
on r.RecipeId = rd.RecipeId
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId
join Cookbook cb 
on cr.CookbookId = cb.CookbookId
where cb.CookbookName = 'Treats for Two'
group by cr.CookbookRecipeId, r.RecipeName, c.CuisineType 

-- April Fools Page:
    -- On April 1st we have a page with a joke cookbook. For that page provide the following.
    -- a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
    -- b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, and a list of the last step in each recipe in the system

select JokeRecipeName = concat(upper(substring(reverse(r.RecipeName),1,1)),lower(substring(reverse(r.RecipeName),2,len(r.RecipeName)))), JokePictureName = concat('Recipe-',replace(lower(substring(reverse(r.RecipeName),1,len(r.RecipeName))),' ','-'),'.jpg') 
from Recipe r 
join CookbookRecipe cr 
on r.RecipeId = cr.RecipeId

/*
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
    Hint: Use CTE
*/
;
with x as(
    select r.RecipeName, LastStep = max(rd.DirectionText)
    from RecipeDirection rd 
    join Recipe r 
    on rd.RecipeId = r.RecipeId
    group by r.RecipeName 
)
select JokeRecipeName = concat(upper(substring(reverse(r.RecipeName),1,1)),lower(substring(reverse(r.RecipeName),2,len(r.RecipeName)))), x.LastStep
from x 
cross join Recipe r 
where r.RecipeName = 'Chocolate Chip Cookies'

--For site administration page:
--5 seperate reports
    --a) List of how many recipes each user created per status. Show 0 if none
select s.FirstName, s.LastName, CurrentStatus = isnull(r.CurrentStatus,''), NumRecipes = count(r.RecipeId)
from Recipe r  
left join Staff s 
on r.StaffId = s.StaffId
group by s.FirstName, s.LastName, r.CurrentStatus
    -- b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
select s.FirstName, s.LastName, NumRecipes = count(r.RecipeId), AvgDaysUntilPublished = avg(datediff(day,r.DraftDate, r.PublishedDate))
from Staff s 
left join Recipe r 
on s.StaffId = r.StaffId
group by s.FirstName, s.LastName
    -- c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
select s.FirstName, s.LastName, NumMeals = count(m.MealId), m.IsActive
from Staff s 
left join Meal m 
on s.StaffId = m.StaffId
group by s.FirstName, s.LastName, m.IsActive
    -- d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
select s.FirstName, s.LastName, NumCookbooks = count(c.CookbookId), c.IsActive
from Staff s 
left join Cookbook c 
on s.StaffId = c.StaffId
group by s.FirstName, s.LastName, c.IsActive
    -- e) List of archived recipes that were never published, and how long it took for them to be archived.
select r.RecipeName, TimeUntilArchived = datediff(day, r.DraftDate, r.ArchivedDate)
from Recipe r
where r.CurrentStatus = 'Archived'
and r.PublishedDate is null  

/*
For user dashboard page:
    a) Show number of the user's recipes, meals and cookbooks. 
    b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
    c) Count of their recipes per cuisine. Show 0 for none.
*/
select s.FirstName, s.LastName, NumRecipes = count(r.RecipeId), NumMeals = count(m.MealId), NumCookbooks = count(c.CookbookId) 
from Staff s 
left join Recipe r 
on s.StaffId = r.StaffId
left join Meal m 
on s.StaffId = m.StaffId
left join Cookbook c 
on s.StaffId = c.StaffId
where s.FirstName = 'Tim'
and s.LastName = 'Jones'
group by s.FirstName, s.LastName

select s.FirstName, s.LastName, r.RecipeName, r.CurrentStatus, HoursBetweenThisStatusAndLast = datediff(hour,
    case r.CurrentStatus
        when 'Published' then r.DraftDate
        when 'Archived' then 
            (case 
                when r.PublishedDate is not null then r.PublishedDate
                else r.DraftDate
            end)
        else null 
    end,
    case r.CurrentStatus 
        when 'Published' then r.PublishedDate 
        when 'Archived' then r.ArchivedDate 
        else null 
    end)
from Staff s 
join Recipe r 
on s.StaffId = r.StaffId
where s.FirstName = 'Tim'
and s.LastName = 'Jones'

select s.FirstName, s.LastName, CuisineType = isnull(c.CuisineType,''),NumRecipes =  count(r.RecipeId)
from Staff s 
left join Recipe r 
on s.StaffId = r.StaffId
left join Cuisine c 
on r.CuisineId = c.CuisineId
where s.FirstName = 'Tim'
and s.LastName = 'Jones'
group by s.FirstName, s.LastName, c.CuisineType
