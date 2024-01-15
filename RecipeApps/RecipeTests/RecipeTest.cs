using CPUFramework;
using RecipeSystems;
using System.Data;

namespace RecipeTests
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        [TestCase("Pizza Balls", "1/1/2023", 250)]
        [TestCase("Sushi Deconstructed", "1/1/2024", 200)]
        public void InsertNewRecipe(string recipename, DateTime draftdate, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int staffid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 staffid from staff");
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(staffid > 0, "can't run test, no staff members in db");
            Assume.That(cuisineid > 0, "can't run test, no cuisine types in db");

            TestContext.WriteLine("insert recipe with name = " + recipename);

            r["StaffId"] = staffid;
            r["CuisineId"] = cuisineid;
            r["RecipeName"] = recipename;
            r["DraftDate"] = draftdate;
            r["Calories"] = calories;
            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = '" + recipename + "'");

            Assert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in db");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            DataTable dt = Recipe.Load(recipeid);
            string name = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid, "RecipeName");
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("name for recipeid " + recipeid + " is " + name);
            name = name + "a";
            TestContext.WriteLine("change name to " + name);

            dt.Rows[0]["RecipeName"] = name;
            Recipe.Save(dt);

            string newname = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid, "RecipeName");
            Assert.IsTrue(newname == name, "name for recipe (" + recipeid + ") = " + newname);
            TestContext.WriteLine("name for recipe (" + recipeid + ") = " + newname);
        }

        [Test]

        //In order to run this test, I had to make the recipename unique (which I had commented out for the insert test),
        //there were no other unique constraints and now the insert test doesn't work.
        //what should I do?
        public void ChangeExistingRecipeToInvalidName()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            string name = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid <> " + recipeid, "RecipeName");
            string currentname = GetFirstColumnFirstRowValueAsString("select recipename from recipe where recipeid = " + recipeid, "RecipeName");
            Assume.That(name != "", "Cannot run test, no other recipe record in the table");
            TestContext.WriteLine("change recipeid " + recipeid + " name from " + currentname + " to " + name + " which belongs to a different recipe");

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = name;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);     
        }

        [Test]
        public void ChangeExistingRecipeCalories()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 1;
            TestContext.WriteLine("change calories to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcalories == calories, "calories for recipe (" + recipeid + ") = " + newcalories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcalories);
        }

        [Test]
        public void ChangeExistingRecipeToInvalidCalories()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = -1;
            TestContext.WriteLine("change calories to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Exception ex = Assert.Throws<Exception> (() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select r.RecipeId, r.recipename from recipe r left join CookbookRecipe cbr on cbr.RecipeId = r.RecipeId left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId where CookbookId is null and MealCourseId is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " ";
            }
            Assume.That(recipeid > 0, "No recipes without cookbooks or meals in DB, can't run test");
            TestContext.WriteLine("Existing recipe without cookbooks or meals, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in db");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");

        }

        [Test]
        public void DeleteRecipeWithCookbooksAndMealsNotDraftedNotArchivedForMoreThan30Days ()
        {
            string sql = @"
select r.RecipeId, r.recipename 
from recipe r 
left join CookbookRecipe cbr 
on cbr.RecipeId = r.RecipeId 
left join MealCourseRecipe mcr 
on mcr.RecipeId = r.RecipeId
where getdate() -  r.ArchivedDate <= 30
or r.CurrentStatus = 'Published'
";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            { 
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"] + " ";
            }
            Assume.That(recipeid > 0, "No recipes with cookbooks and meals that aren't drafted or archived for more than 30 days in DB, can't run test");
            TestContext.WriteLine("Existing recipe with cookbooks and meals that aren't drafted or archived for more than 30 days, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app cannot delete " + recipeid);
            
            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeid();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
        }

        [Test]
        public void SearchRecipes()
        {
            string criteria = "a";
            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(num > 0, "There are no recipes that match the search for " + num);
            TestContext.WriteLine(num + " recipes that match " + criteria);
            TestContext.WriteLine("Ensure that recipe search returns " + num + " rows");

            DataTable dt = Recipe.SearchRecipes(criteria);
            int results = dt.Rows.Count;

            Assert.IsTrue(results == num, "Results of recipe search does not match num of recipes, " + results + "<>" + num);
            TestContext.WriteLine("Num of rows returned by recipe search is " + results);
        }

        [Test]
        public void GetListOfStaffMembers()
        {
            int staffcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from staff");
            Assume.That(staffcount > 0, "No staff members in DB, can't test");
            TestContext.WriteLine("Num of staff members in DB = " + staffcount);
            TestContext.WriteLine("Ensure that num of rows returned by app = " + staffcount);

            DataTable dt = Recipe.GetStaffList();

            Assert.IsTrue(dt.Rows.Count == staffcount, "num rows returned by app (" + dt.Rows.Count + ") <> " + staffcount);

            TestContext.WriteLine("Number of rows in Staff returned by app = " + dt.Rows.Count);

        }

        [Test]
        public void GetListOfCuisine()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisine types in DB, can't test");
            TestContext.WriteLine("Num of cuisine types in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows returned by app = " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);

            TestContext.WriteLine("Number of rows in Cuisine returned by app = " + dt.Rows.Count);

        }

        private int GetExistingRecipeid()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

        private string GetFirstColumnFirstRowValueAsString(string sql, string columnname)
        {
            string s = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][columnname].ToString();
                }
            }
            return s;
        }
    }
}

