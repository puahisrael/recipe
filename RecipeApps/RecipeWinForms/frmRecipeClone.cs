namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        public frmRecipeClone()
        {
            InitializeComponent();
<<<<<<< HEAD
            btnClone.Click += BtnClone_Click;
=======
>>>>>>> 770cecf8444e5900a59a45ecae03fc5c300bb59e
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
