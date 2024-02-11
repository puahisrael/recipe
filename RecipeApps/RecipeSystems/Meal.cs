using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class Meal
    {
        public static DataTable GetMealList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("MealGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
