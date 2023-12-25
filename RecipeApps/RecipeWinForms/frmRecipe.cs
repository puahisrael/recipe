using CPUFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form 
    {
        DataTable dtrecipe;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);

            DataTable dtStaff = Recipe.GetStaffList();
            DataTable dtCuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstLastName, dtStaff, dtrecipe, "Staff");
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtDraftDate, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtPublishedDate, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtArchivedDate, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            this.Show();
        }

        private void Save()
        {
            Recipe.Save(dtrecipe);
        }

        private void Delete()
        {
            Recipe.Delete(dtrecipe);
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
