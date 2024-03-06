-- SM Excellent! See comments. I believe you're ready to create the database. If any of my comments are unclear, please ask me on slack and I'll try to explain it more.
/*
HeartyHearthDB

Staff
    StaffId
    FirstName varchar(30)
        can't be blank 
    LastName varchar(30)
        can't be blank
    MeasurementName varchar(30)
        unique
        can't be blank

Ingredient
    IngredientId
    IngredientName varchar(50)
        unique
        can't be blank
    PictureName computed (Ingredient-IngredientName.jpg)

Cuisine 
    CuisineId
    CuisineType varchar(30)
        unique
        can't be blank

MeasurementType
    MeasurementTypeId
    MeasurementTypeName varchar(30)

Course
    CourseId
    CourseName varchar(15)
        can't be blank
    CourseSequence int not null 
    unique (CourseId, CourseSequence)

Recipe
    RecipeId
    StaffId (fk Staff)
    CuisineId (fk Cuisine)
    RecipeName varchar(50)
        unique
        can't be blank
    DraftDate datetime not null default getdate()
        can't be in the future
    PublishedDate null datetime
        can't be in the future
    ArchivedDate null datetime
        can't be in future
    Calories int datetime
        can't be negative
    PictureName computed (Recipe-RecipeName.jpg)
    CurrentStatus computed 
        (
        case 
            when ArchivedDate is null 
            then case 
                when PublishedDate is null 
                then 'Draft' 
                else 'Published'
            else 'Archived'
        )
    constraint (DraftDate must be before PublishedDate)
    constraint (PublishedDate must be before ArchivedDate)

Meal
    MealId 
    StaffId (fk Staff)
    MealName varchar(50)
        unique
        can't be blank
    IsActive bit not null
    DateCreated date
    PictureName computed (Meal-MealName.jpg)

CookBook
    CookBookId
    StaffId (fk Staff)
    CookBookName varchar(50)
        unique
        can't be blank
    Price decimal(5,2)
    IsActive bit not null
    DateCreated date not null 
    PictureName computed (CookBook-CookBookName)


RecipeDirection
    DirectionId
    RecipeId (fk Recipe)
    DirectionNum int
        greater than 0
    DirectionText varchar(500)
        can't be blank
    unique (RecipeId, DirectionNum)

RecipeIngredient
    RecipeIngredientId
    RecipeId (fk Recipe)
    IngredientId (fk Ingredient)
    MeasurementTypeId (fk MeasurementType)
    Amount int not null
        greater than 0
    IngredientSequence int not null 
    unique (RecipeId, IngredientSequence)

MealCourse
    MealCourseId
    MealId (fk Meal)
    CourseId (fk Course)

MealCourseRecipe
    MealCourseRecipeId
    MealCourseId (fk Course)
    RecipeId (fk Recipe)
    IsMainDish bit not null
    
CookBookRecipe
    CookBookRecipeId 
    CookBookId (fk CookBook)
    RecipeId (fk Recipe)
    RecipeSequence int not null
    unique (CookBookId, RecipeSequence)
    unique (CookBookId, RecipeId)
*/