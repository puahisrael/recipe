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
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();

            this.Activated += FrmRecipeClone_Activated;
        }

        private void FrmRecipeClone_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dtMeasurement = Recipe.GetRecipeList();
            lstRecipes.DisplayMember = "RecipeName";
            WindowsFormsUtility.SetListBinding(lstRecipes, dtMeasurement, dtMeasurement, "Recipe");
        }
    }
}
