-- SM Excellent! 100%
use HeartyHearthDB
go 
delete CookBookRecipe
delete MealCourseRecipe
delete MealCourse
delete RecipeIngredient
delete RecipeDirection
delete Cookbook
delete Meal
delete Recipe 
delete Course
delete MeasurementType
delete Cuisine
delete Ingredient
delete Staff
go 

insert Staff(FirstName,LastName,UserName)
select 'Bob', 'Smith', 'bobsmith!'
union select 'Tim', 'Jones', 'timjones!'
union select 'Kate', 'Richardson', 'katerichardson!'
union select 'Sally', 'Timmons', 'sallytimmons!'

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Flour'
union select 'Oil'
union select 'Eggs'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apples'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Club Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Olive Oil'
union select 'Cranberry Sauce'
union select 'Onion Soup Mix'
union select 'Water'
union select 'Cucumbers'
union select 'Tomatoes'
union select 'Peppers'
union select 'Pickles'

insert Cuisine(CuisineType)
select 'American'
union select 'French'
union select 'English'
union select 'Israeli'
union select 'Universal'

insert MeasurementType(MeasurementTypeName)
select 'Cup'
union select 'Tsp'
union select 'Tbsp'
union select 'Ounces'
union select 'Cloves (crushed)'
union select 'Pinch'
union select 'Stick'

insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main Course', 2
union select 'Dessert', 3

;
with x as (
    select FirstName = 'Bob', LastName = 'Smith', CuisineType = 'American', RecipeName = 'Chocolate Chip Cookies', DraftDate = '01/01/2010', PublishedDate = '01/02/2010', ArchivedDate = null, Calories = 200
    union select 'Tim', 'Jones', 'French', 'Apple Yogurt Smoothie', '01/01/2015', '02/02/2015', null, 100
    union select 'Kate', 'Richardson', 'English', 'Cheese Bread', '01/01/2020', '02/02/2020', null, 250
    union select 'Sally', 'Timmons', 'American', 'Butter Muffins', '01/01/2023', '02/02/2023', null, 150 
    union select 'Bob', 'Smith', 'Israeli', 'Israeli Salad', '01/01/2012', '02/02/2012', null, 50
    union select 'Tim', 'Jones', 'French', 'French Roast', '01/01/2021', null, null, 300
    union select 'Kate', 'Richardson', 'Universal', 'Salt Water', '01/01/2017', null, '03/03/2017', 5
)
insert Recipe(StaffId, CuisineId, RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories)
select s.StaffId, c.CuisineId, x.RecipeName, x.DraftDate, x.PublishedDate, x.ArchivedDate, x.Calories
from x 
join Staff s  
on s.FirstName = x.FirstName
and s.LastName = x.LastName
join Cuisine c  
on c.CuisineType = x.CuisineType

;
with x as (
    select FirstName = 'Bob', LastName = 'Smith', MealName = 'Breakfast Bash', IsActive = 1, DateCreated = '03/03/2023'
    union select 'Tim', 'Jones', 'Lunch Licks', 1, '03/04/2023'
    union select 'Sally', 'Timmons', 'Dinner Delight', 1, '01/01/2021'
    union select 'Sally', 'Timmons', 'Random Party', 0, '10/01/2020'
)
insert Meal(StaffId, MealName, IsActive, DateCreated)
select s.StaffId, x.MealName, x.IsActive, x.DateCreated
from x 
join Staff s 
on s.FirstName = x.FirstName
and s.LastName = x.LastName

;
with x as (
    select FirstName = 'Kate', LastName = 'Richardson', CookbookName = 'Treats for Two', Price = 30, IsActive = 1, DateCreated = '03/04/2023'
    union select 'Kate', 'Richardson', 'Good Food', 25, 1, '01/01/2022'
    union select 'Sally', 'Timmons', 'Yum!', 35, 1, '10/01/2022'
    union select 'Bob', 'Smith', 'This is a Cookbook',20, 0, '01/01/2020'
)
insert Cookbook(StaffId, CookbookName, Price, IsActive, DateCreated)
select s.StaffId, x.CookbookName, x.Price, x.IsActive, x.DateCreated
from x 
join Staff s 
on s.FirstName = x.FirstName 
and s.LastName = x.LastName

;
with x as (
    select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 1, DirectionText = 'First combine sugar, oil and eggs in a bowl'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 2, DirectionText = 'Mix well'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 3, DirectionText = 'Add flour, vanilla sugar, baking powder and baking soda'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 4, DirectionText = 'Beat for 5 minutes'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 5, DirectionText = 'Add chocolate chips'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 6, DirectionText = 'Freeze for 1-2 hours'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 7, DirectionText = 'Roll into balls and place spread out on a cookie sheet'
    union select RecipeName = 'Chocolate Chip Cookies', DirectionNum = 8, DirectionText = 'Bake on 350 for 10 min'
    union select RecipeName = 'Apple Yogurt Smoothie', DirectionNum = 1, DirectionText = 'Peel the apples and dice'
    union select RecipeName = 'Apple Yogurt Smoothie', DirectionNum = 2, DirectionText = 'Combine all ingredients in bowl except for apples and ice cubes'
    union select RecipeName = 'Apple Yogurt Smoothie', DirectionNum = 3, DirectionText = 'Mix until smooth'
    union select RecipeName = 'Apple Yogurt Smoothie', DirectionNum = 4, DirectionText = 'Add apples and ice cubes'
    union select RecipeName = 'Apple Yogurt Smoothie', DirectionNum = 5, DirectionText = 'Pour into glasses'
    union select RecipeName = 'Cheese Bread', DirectionNum = 1, DirectionText = 'Slit bread every 3/4 inch'
    union select RecipeName = 'Cheese Bread', DirectionNum = 2, DirectionText = 'Combine all ingredients in bowl'
    union select RecipeName = 'Cheese Bread', DirectionNum = 3, DirectionText = 'Fill slits with cheese mixture'
    union select RecipeName = 'Cheese Bread', DirectionNum = 4, DirectionText = 'Wrap bread into a foil and bake for 30 minutes'
    union select RecipeName = 'Butter Muffins', DirectionNum = 1, DirectionText = 'Cream butter with sugars'
    union select RecipeName = 'Butter Muffins', DirectionNum = 2, DirectionText = 'Add eggs and mix well'
    union select RecipeName = 'Butter Muffins', DirectionNum = 3, DirectionText = 'Slowly add rest of ingredients and mix well'
    union select RecipeName = 'Butter Muffins', DirectionNum = 4, DirectionText = 'fill muffin pans 3/4 full and bake for 30 minutes'
    union select RecipeName = 'Israeli Salad', DirectionNum = 1, DirectionText = 'Dice all vegetables'
    union select RecipeName = 'Israeli Salad', DirectionNum = 2, DirectionText = 'Drizzle olive oil over salad'
    union select RecipeName = 'Israeli Salad', DirectionNum = 3, DirectionText = 'Season with salt and pepper'
    union select RecipeName = 'Israeli Salad', DirectionNum = 4, DirectionText = 'Mix'
    union select RecipeName = 'French Roast', DirectionNum = 1, DirectionText = 'Rub roast with sauce and soup mix'
    union select RecipeName = 'French Roast', DirectionNum = 2, DirectionText = 'Put in pan with water'
    union select RecipeName = 'French Roast', DirectionNum = 3, DirectionText = 'Bake at 350 for 2 hours'
    union select RecipeName = 'Salt Water', DirectionNum = 1, DirectionText = 'Mix salt and water together'
)
insert RecipeDirection(RecipeId, DirectionNum, DirectionText)
select r.RecipeId, x.DirectionNum, x.DirectionText
from x 
join Recipe r 
on r.RecipeName = x.RecipeName

;
with x as(
    select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'Sugar', MeasurementTypeName = 'Cup', Amount = 1, IngredientSequence = 1
    union select 'Chocolate Chip Cookies', 'Oil', 'Cup', .5, 2
    union select 'Chocolate Chip Cookies', 'Eggs', null, 3, 3
    union select 'Chocolate Chip Cookies', 'Flour', 'Cup', 2, 4
    union select 'Chocolate Chip Cookies', 'Vanilla Sugar', 'Tsp', 1, 5
    union select 'Chocolate Chip Cookies', 'Baking Powder', 'Tsp', 2, 6
    union select 'Chocolate Chip Cookies', 'Baking Soda', 'Tsp', .5, 7
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 'Cup', 1, 8
    union select 'Apple Yogurt Smoothie', 'Granny Smith Apples', null, 3, 1
    union select 'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'Cup', 2, 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 'Tsp', 2, 3
    union select 'Apple Yogurt Smoothie', 'Orange Juice', 'Cup', .5, 4
    union select 'Apple Yogurt Smoothie', 'Honey', 'Tbsp', 2, 5
    union select 'Apple Yogurt Smoothie', 'Ice Cubes', null, 5, 6
    union select 'Cheese Bread', 'Club Bread', null, 1, 1
    union select 'Cheese Bread', 'Butter', 'Ounces', 4, 2
    union select 'Cheese Bread', 'Shredded Cheese', 'Ounces', 8, 3
    union select 'Cheese Bread', 'Garlic', 'Cloves (crushed)', 2, 4
    union select 'Cheese Bread', 'Pepper', 'Tsp', .25, 5
    union select 'Cheese Bread', 'Salt', 'Pinch', 1, 6
    union select 'Butter Muffins', 'Butter', 'Stick', 1, 1
    union select 'Butter Muffins', 'Sugar', 'Cup', 3, 2
    union select 'Butter Muffins', 'Vanilla Pudding', 'Tbsp', 2, 3
    union select 'Butter Muffins', 'Eggs', null, 4, 4
    union select 'Butter Muffins', 'Whipped Cream Cheese', 'Ounces', 8, 5
    union select 'Butter Muffins', 'Sour Cream Cheese', 'Ounces', 8, 6
    union select 'Butter Muffins', 'Flour', 'Cup', 1, 7
    union select 'Butter Muffins', 'Baking Powder', 'Tsp', 2, 8
    union select 'Israeli Salad', 'Cucumbers', null, 2, 1
    union select 'Israeli Salad', 'Tomatoes', null, 4, 2
    union select 'Israeli Salad', 'Peppers', null, 2, 3
    union select 'Israeli Salad', 'Pickles', null, 3, 4
    union select 'Israeli Salad', 'Olive Oil', 'Tbsp', 3, 5
    union select 'Israeli Salad', 'Salt', 'Tsp', 2, 6
    union select 'Israeli Salad', 'Pepper', 'Tsp', 1, 7
    union select 'French Roast', 'French Roast', null, 1, 1
    union select 'French Roast', 'Cranberry Sauce', 'Ounces', 8, 2
    union select 'French Roast', 'Onion Soup Mix', 'Tbsp', 6, 3
    union select 'French Roast', 'Water', 'Cup', 5, 4
    union select 'Salt Water', 'Salt', 'Cup', .25, 1
    union select 'Salt Water', 'Water', 'Cup', .75, 2
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

select * from RecipeIngredient 

;
with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Appetizer'
    union select MealName = 'Breakfast Bash', CourseName = 'Main Course'
    union select MealName = 'Lunch Licks', CourseName = 'Appetizer'
    union select MealName = 'Lunch Licks', CourseName = 'Main Course'
    union select MealName = 'Dinner Delight', CourseName = 'Appetizer'
    union select MealName = 'Dinner Delight', CourseName = 'Main Course'
    union select MealName = 'Dinner Delight', CourseName = 'Dessert'
    union select MealName = 'Random Party', CourseName = 'Main Course'
)
insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from x 
join Meal m 
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName

;
with x as(
    select MealName = 'Breakfast Bash', CourseName = 'Appetizer', RecipeName = 'Apple Yogurt Smoothie', IsMainDish = 1
    union select MealName = 'Breakfast Bash', CourseName = 'Main Course', RecipeName = 'Cheese Bread', IsMainDish = 1
    union select MealName = 'Breakfast Bash', CourseName = 'Main Course', RecipeName = 'Butter Muffins', IsMainDish = 0
    union select MealName = 'Lunch Licks', CourseName = 'Appetizer', RecipeName = 'Salt Water', IsMainDish = 1
    union select MealName = 'Lunch Licks', CourseName = 'Main Course', RecipeName = 'Cheese Bread', IsMainDish = 1
    union select MealName = 'Dinner Delight', CourseName = 'Appetizer', RecipeName = 'Butter Muffins', IsMainDish = 1
    union select MealName = 'Dinner Delight', CourseName = 'Main Course', RecipeName = 'French Roast', IsMainDish = 1
    union select MealName = 'Dinner Delight', CourseName = 'Main Course', RecipeName = 'Israeli Salad', IsMainDish = 0
    union select MealName = 'Dinner Delight', CourseName = 'Dessert', RecipeName = 'Chocolate Chip Cookies', IsMainDish = 1
    union select MealName = 'Random Party', CourseName = 'Main Course', RecipeName = 'Salt Water', IsMainDish = 1
)
insert MealCourseRecipe(MealCourseId, RecipeId, IsMainDish)
select mc.MealCourseId, r.RecipeId, x.IsMainDish
from x  
join Recipe r 
on r.RecipeName = x.RecipeName
join Meal m
on m.MealName = x.MealName
join Course c 
on c.CourseName = x.CourseName
join MealCourse mc 
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId

;
with x as(
    select CookbookName = 'Treats for Two', RecipeName = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select CookbookName = 'Treats for Two', RecipeName = 'Apple Yogurt Smoothie', RecipeSequence = 2
    union select CookbookName = 'Treats for Two', RecipeName = 'Cheese Bread', RecipeSequence = 3
    union select CookbookName = 'Treats for Two', RecipeName = 'Butter Muffins', RecipeSequence = 4
    union select CookbookName = 'Good Food', RecipeName = 'French Roast', RecipeSequence = 1
    union select CookbookName = 'Good Food', RecipeName = 'Butter Muffins', RecipeSequence = 2
    union select CookbookName = 'Good Food', RecipeName = 'Chocolate Chip Cookies', RecipeSequence = 3
    union select CookbookName = 'Yum', RecipeName = 'Butter Muffins', RecipeSequence = 1
    union select CookbookName = 'Yum!', RecipeName = 'Cheese Bread', RecipeSequence = 2
    union select CookbookName = 'Yum!', RecipeName = 'Apple Yogurt Smoothie', RecipeSequence = 3
    union select CookbookName = 'Yum!', RecipeName = 'Israeli Salad', RecipeSequence = 4
    union select CookbookName = 'Yum!', RecipeName = 'Chocolate Chip Cookies', RecipeSequence = 5
    union select CookbookName = 'This is a Cookbook', RecipeName = 'Salt Water', RecipeSequence = 1
    union select CookbookName = 'This is a Cookbook', RecipeName = 'French Roast', RecipeSequence = 2
)
insert CookbookRecipe(CookbookId, RecipeId, RecipeSequence)
select c.CookBookId, r.RecipeId, x.RecipeSequence
from x
join Cookbook c 
on c.CookBookName = x.CookbookName
join Recipe r 
on r.RecipeName = x.RecipeName 