namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList() 
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmRecipeList_Activated;
            //gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            //btnNewRecipe.Click += BtnNewRecipe_Click;
        }

        private void BindData()
        {
            DataTable dt = Recipe.GetRecipeList();
            gRecipeData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeData, "Recipe");
            gRecipeData.Columns["RecipeId"].Visible = false;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        //private void ShowRecipeForm(int rowindex)
        //{
        //    int id = 0;
        //    if (rowindex > -1)
        //    {
        //        id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
        //    }
        //    frmRecipeEdit frm = new();
        //    frm.LoadForm(id);
        //}

        //private void BtnNewRecipe_Click(object? sender, EventArgs e)
        //{
        //    ShowRecipeForm(-1);
        //}

        //private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        //{
        //    ShowRecipeForm(e.RowIndex);
        //}
    }
}
