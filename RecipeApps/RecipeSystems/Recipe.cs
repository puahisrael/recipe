namespace RecipeSystems
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetStaffList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("StaffGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            SQLUtility.DebugPrintDataTable(dtrecipe);
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                    $"update recipe set",
                    $"StaffId = '{r["StaffId"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"DraftDate = '{r["DraftDate"]}',",
                    //$"PublishedDate = '{r["PublishedDate"]}',",
                    //$"ArchivedDate = '{r["ArchivedDate"]}',",
                    $"Calories = '{r["Calories"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe(StaffId, CuisineId, RecipeName, DraftDate, Calories) ";
                sql += $"select '{r["StaffId"]}', '{r["CuisineId"]}', '{r["RecipeName"]}', '{r["DraftDate"]}', '{r["Calories"]}'";
            }

            Debug.Print("-------------");

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
