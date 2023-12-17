using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form 
    {
        public frmRecipe()
        {
            InitializeComponent();
        }


        public void ShowForm(int RecipeId)
        {
            string sql = "select * from recipe r where r.recipeid = " + RecipeId.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName"); 
            txtDateDrafted.DataBindings.Add("Text", dt, "DraftDate");
            txtDatePublished.DataBindings.Add("Text", dt, "PublishedDate");
            txtDateArchived.DataBindings.Add("Text", dt, "ArchivedDate");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            this.Show();
        }

    }
}

//RecipeName, DraftDate, PublishedDate, ArchivedDate, Calories
