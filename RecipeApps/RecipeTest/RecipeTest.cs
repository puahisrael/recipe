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
    }
}
