using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void SetUp()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, RecipeName from recipe r left join CookbookRecipe c on c.recipeid = r.recipeid left join mealcourserecipe m on m.recipeid = r.recipeid where m.mealcourseid is null and c.cookbookid is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " ";
            }
            Assume.That(recipeid > 0, "No presidents without meals or cookbooks in DB, can't run test");
            TestContext.WriteLine("Existing president without meals or cookbooks, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("Ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipedid " + recipeid + " exists in db");
            TestContext.WriteLine("Record with presidentid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadid == recipeid, loadid + " <> " + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadid + ")");
        }

        [Test]
        public void GetlistOfStaff()
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
        public void GetlistOfCuisine()
        {
            int cuisinecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No cuisine types in DB, can't test");
            TestContext.WriteLine("Num of cuisine types in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that num of rows returned by app = " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.IsTrue(dt.Rows.Count == cuisinecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinecount);

            TestContext.WriteLine("Number of rows in Cuisine returned by app = " + dt.Rows.Count);
        }


        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
