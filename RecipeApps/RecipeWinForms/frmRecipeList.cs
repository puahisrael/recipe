namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList() 
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
        }

        private void SearchForRecipe(string recipename)
        {
            DataTable dt = Recipe.SearchRecipes(recipename);
            gRecipe.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipeEdit frm = new();
            frm.ShowForm(id);
        }
        
        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipe(txtRecipeName.Text);
        }
    }
}
