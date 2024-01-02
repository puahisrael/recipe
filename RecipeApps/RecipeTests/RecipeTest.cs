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
        public void InsertNewPresident(string recipename, DateTime draftdate, int calories)
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

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = " + recipename);

            Assert.IsTrue(newid > 0, "recipe with name = " + recipename + " is not found in db");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            DataTable dt = Recipe.Load(recipeid);
            string name = dt.Rows[0]["RecipeName"].ToString();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("name for recipeid " + recipeid + " is " + name);
            name = name + "a";
            TestContext.WriteLine("change name to " + name);

            dt.Rows[0]["RecipeName"] = name;
            Recipe.Save(dt);

            string newname = dt.Rows[0]["RecipeName"].ToString();
            Assert.IsTrue(newname == name, "name for recipe (" + recipeid + ") = " + newname);
            TestContext.WriteLine("name for recipe (" + recipeid + ") = " + newname);
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
        public void DeletePresident()
        {
            DataTable dt = SQLUtility.GetDataTable("select r.RecipeId, r.calories from recipe r left join CookbookRecipe cbr on cbr.RecipeId = r.RecipeId left join MealCourseRecipe mcr on mcr.RecipeId = r.RecipeId where CookbookId is null and MealCourseId is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["calories"] + " ";
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
        public void LoadPresident()
        {
            int recipeid = GetExistingrecipeid();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedid + ")");
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

        private int GetExistingrecipeid()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
