using RecipeSystems;
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
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmMealList_Activated;
        }

        private void BindData()
        {   
            DataTable dt = Meal.GetMealList();
            gMealData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gMealData, "Meal");
            gMealData.Columns["MealId"].Visible = false;
        }

        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
