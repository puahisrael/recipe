namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList() 
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmRecipeList_Activated;
            gRecipeData.CellDoubleClick += GRecipeData_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;
        }


        private void BindData()
        {
            DataTable dt = Recipe.GetRecipeList();
            gRecipeData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeData, "Recipe");
            gRecipeData.Columns["RecipeId"].Visible = false;
            gRecipeData.Columns["CuisineType"].Visible = false;
            gRecipeData.Columns["DraftDate"].Visible = false;
            gRecipeData.Columns["PublishedDate"].Visible = false;
            gRecipeData.Columns["ArchivedDate"].Visible = false;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeData, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), id);
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipeData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }
    }
}
