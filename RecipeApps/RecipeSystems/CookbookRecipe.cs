using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class CookbookRecipe
    {
        public static DataTable LoadByCookbookId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        //public static void SaveTable(DataTable dt, int recipeid)
        //{
        //    foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
        //    {
        //        r["RecipeId"] = recipeid;
        //    }
        //    SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        //}

        //public static void Delete(int recipeingredientid)
        //{
        //    SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
        //    cmd.Parameters["@RecipeIngredientId"].Value = recipeingredientid;
        //    SQLUtility.ExecuteSQL(cmd);
        //}
    }
}
