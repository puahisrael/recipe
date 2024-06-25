namespace RecipeWinForms
{
    public partial class frmRecipeClone : Form
    {
        DataTable dtrecipe = new();
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
            WindowsFormsUtility.SetListBinding(lstRecipes, DataMaintenance.GetDataList("Recipe", true), null, "Recipe");
            lstRecipes.DisplayMember = "RecipeName";
        }

        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipes);
            Cursor = Cursors.WaitCursor;
            try
            {
                Recipe.CloneRecipe(recipeid);
                lstRecipes.SelectedValue = ;
                int newid = WindowsFormsUtility.GetIdFromComboBox(lstRecipes);
                lstRecipes.SelectedValue = newid;
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), newid);
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
