﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystems
{
    public class Cookbook
    {
        public static DataTable GetCookbookList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookbookSave method because there are no rows in the table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void AutoCreateCookbook(int userid, string cookbookname, int price, bool isactive, string datecreated)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookAutoCreate");
            SQLUtility.SetParamValue(cmd, "@UserId", userid);
            SQLUtility.SetParamValue(cmd, "@CookbookName", cookbookname);
            SQLUtility.SetParamValue(cmd, "@Price", price);
            SQLUtility.SetParamValue(cmd, "@IsActive", isactive);
            SQLUtility.SetParamValue(cmd, "@DateCreated", datecreated);
            SQLUtility.ExecuteSQL(cmd);

        }
    }
}
