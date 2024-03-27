namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
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

        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipes);
            int id;
            Cursor = Cursors.WaitCursor;
            try
            {
                Recipe.CloneRecipe(recipeid);
                //FIGURE OUT HOW TO LOAD NEW RECIPE FORM, NOT THE ONE THAT IT WAS CLONED FROM
                id = WindowsFormsUtility.GetIdFromComboBox(lstRecipes);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), id);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();    
        }
    }
}
