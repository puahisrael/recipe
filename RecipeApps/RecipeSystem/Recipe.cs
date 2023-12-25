using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipename)
        {
            string sql = "select r.RecipeId, r.RecipeName, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories from recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, 'Name' = s.FirstName + s.LastName, c.CuisineType from recipe r join staff s on s.staffid = r.staffid join cuisine c on c.cuisineid = r.cuisineid where r.recipeid = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetStaffList()
        {
            return SQLUtility.GetDataTable("select staffid, lastname from staff");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select cuisineid, cuisinetype from cuisine");
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
                    $"StaffId = ' {r["StaffId"]}',",
                    $"CuisineId = ' {r["CuisineId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"DraftDate = '{r["DraftDate"]}',",
                    $"PublishedDate = '{r["PublishedDate"]}',",
                    $"ArchivedDate = '{r["ArchivedDate"]}',",
                    $"Calories = '{r["Calories"]}'",
                    $"where RecipeId = {r["RecipeId"]}");
            }

            Debug.Print("-------------");

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where recipeid = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
