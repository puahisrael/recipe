using CPUFramework;
using CPUWindowsFormFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form 
    {
        DataTable dtRecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int RecipeId)
        {
            string sql = "select r.*, 'Name' = s.FirstName + s.LastName, c.CuisineType from recipe r join staff s on s.staffid = r.staffid join cuisine c on c.cuisineid = r.cuisineid where r.recipeid = " + RecipeId.ToString();
            dtRecipe = SQLUtility.GetDataTable(sql);
            DataTable dtStaff = SQLUtility.GetDataTable("select StaffId, LastName from Staff s");
            DataTable dtCuisine = SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
            WindowsFormsUtility.SetListBinding(lstLastName, dtStaff, dtRecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtDraftDate, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtPublishedDate, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtArchivedDate, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";
            if(id > 0)
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

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where recipeid = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}

//RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories
