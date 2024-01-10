-- SM Excellent! 100%
use HeartyHearthDB
go 
drop table if exists CookBookRecipe
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists RecipeIngredient
drop table if exists RecipeDirection
drop table if exists Cookbook 
drop table if exists Meal
drop table if exists Recipe 
drop table if exists Course
drop table if exists MeasurementType
drop table if exists Cuisine
drop table if exists Ingredient
drop table if exists Staff
go 
create table dbo.Staff(
    StaffId int not null identity primary key,
    FirstName varchar(30) not null constraint c_Staff_FirstName_cannot_be_blank check(FirstName <> ''),
    LastName varchar(30) not null constraint c_Staff_LastName_cannot_be_blank check(LastName <> ''),
    UserName varchar(30) not null 
        constraint u_Staff_UserName unique
        constraint c_Staff_UserName_cannot_be_blank check(UserName <> '')
)
create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(50) not null 
        constraint u_Ingredient_IngredientName unique
        constraint c_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> ''),
    PictureName as concat('Ingredient-',replace(IngredientName,' ','-'),'.jpg') persisted 
)
create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(30) not null
        constraint u_Cuisine_CuisineType unique
        constraint c_Cuisine_CuisineType_cannot_be_blank check(CuisineType <> '')
)
create table dbo.MeasurementType(
    MeasurementTypeId int not null identity primary key, 
    MeasurementTypeName varchar(30) not null 
        constraint u_MeasurementType_MeasurementTypeName unique
        constraint c_MeasurementType_MeasurementTypeName_cannot_be_blank check(MeasurementTypeName <> '')
)
create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(15)
        constraint u_Course_CourseName unique
        constraint c_Course_CourseName_cannot_be_blank check(CourseName <> ''),
    CourseSequence int not null 
        constraint u_Course_CourseSequence unique 
        constraint c_Course_CourseSequence_must_be_greater_than_0 check(CourseSequence > 0)
)
create table dbo.Recipe(
    RecipeId int not null identity primary key,
    StaffId int not null constraint f_Staff_Recipe foreign key references Staff(StaffId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(50) not null 
        --constraint u_Recipe_RecipeName unique
        constraint c_Recipe_RecipeName_cannot_be_blank check(RecipeName <> ''),
    DraftDate datetime not null default getdate() constraint c_Recipe_DraftDate_cannot_be_in_the_future check(DraftDate <= getdate()),
    PublishedDate datetime null constraint c_Recipe_PublishedDate_cannot_be_in_the_future check(PublishedDate <= getdate()), 
    ArchivedDate datetime null constraint c_Recipe_ArchivedDate_cannot_be_in_the_future check(ArchivedDate <= getdate()), 
    Calories int not null constraint c_Recipe_Calories_cannot_be_negative check(Calories >= 0),
    PictureName as concat('Recipe-',replace(RecipeName,' ','-'),'.jpg') persisted,
    CurrentStatus as 
        case 
            when ArchivedDate is null  
            then case 
                    when PublishedDate is null 
                    then 'Draft'
                    else 'Published'
                  end
            else 'Archived'
        end
        persisted,
    constraint c_DraftDate_must_be_before_PublishedDate check(DraftDate <= PublishedDate),
    constraint c_PublishedDate_must_be_before_ArchivedDate check(PublishedDate <= ArchivedDate)
)
create table dbo.Meal(
    MealId int not null identity primary key,
    StaffId int not null constraint f_Staff_Meal foreign key references Staff(StaffId),
    MealName varchar(50) not null
        constraint u_Meal_MealName unique
        constraint c_Meal_MealName_cannot_be_blank check(MealName <> ''),
    IsActive bit not null default 1,
    DateCreated date not null constraint c_Meal_DateCreated_cannot_be_in_future check(DateCreated < getdate()),
    PictureName as concat('Meal-',replace(MealName,' ','-'),'.jpg') persisted 
)
create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    StaffId int not null constraint f_Staff_Cookbook foreign key references Staff(StaffId),
    CookbookName varchar(50) not null 
        constraint u_Cookbook_CookbookName unique
        constraint c_Cookbook_CookbookName_cannot_be_blank check(CookbookName <> ''),
    Price decimal(5,2) not null constraint c_Cookbook_Price_must_be_greater_than_0 check(Price > 0),
    IsActive bit not null default 1,
    DateCreated date not null constraint c_Cookbook_DateCreated_cannot_be_in_future check(DateCreated < getdate()), 
    PictureName as concat('Cookbook-',replace(CookbookName,' ','-'),'.jpg') persisted 
)        
create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key, 
    RecipeId int not null constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    DirectionNum int not null constraint c_RecipeDirection_DirectionNum_must_be_greater_than_0 check(DirectionNum > 0),
    DirectionText varchar(500) not null constraint c_RecipeDirection_DirectionText_cannot_be_blank check(DirectionText <> ''),
    constraint u_RecipeDirection_Recipe_DirectionNum unique(RecipeId, DirectionNum)
)
create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementTypeId int null constraint f_MeasurementType_RecipeIngredient foreign key references MeasurementType(MeasurementTypeId),
    Amount decimal(4,2) not null constraint c_RecipeIngredient_Amount_cannot_be_negative check(Amount >= 0),
    IngredientSequence int not null constraint c_RecipeIngredient_IngredientSequence_must_be_greater_than_0 check(IngredientSequence > 0),
    constraint u_RecipeIngredient_Recipe_IngredientSequence unique(RecipeId, IngredientSequence),
    constraint u_RecipeIngredient_Recipe_Ingredient unique(RecipeId, IngredientId)
)
create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_MealCourse_Meal foreign key references Meal(MealId),
    CourseId int not null constraint f_MealCourse_Course foreign key references Course(CourseId),
    constraint u_MealCourse_Meal_Course unique(MealId, CourseId) 
)
create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    IsMainDish bit not null,
    constraint u_MealCourseRecipe_MealCourse_Recipe unique(MealCourseId, RecipeId)
)
create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookRecipe foreign key references Recipe(RecipeId),
    RecipeSequence int not null constraint c_CookbookRecipe_RecipeSequence_must_be_greater_than_0 check(RecipeSequence > 0),
    constraint u_CookbookRecipe_Cookbook_RecipeSequence unique(CookbookId, RecipeSequence),
    constraint u_CookbookRecipe_Cookbook_Recipe unique(CookbookId, RecipeId)
)