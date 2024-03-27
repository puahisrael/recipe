using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class RecipeDirection
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeDirectionUpdate");
        }

        public static void Delete(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDirectionDelete");
            cmd.Parameters["@RecipeDirectionId"].Value = recipeingredientid;
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
