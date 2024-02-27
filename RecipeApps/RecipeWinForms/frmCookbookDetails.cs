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
    public partial class frmCookbookDetails : Form
    {
        DataTable dtcookbook = new();
        DataTable dtcookbookrecipe = new();
        BindingSource bindsource = new();
        string deletecolname = "deletecol";
        int cookbookid = 0;

        public frmCookbookDetails()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmCookbookDetails_FormClosing;
            btnRecipeSave.Click += BtnRecipeSave_Click;
            gRecipeData.CellContentClick += GRecipeData_CellContentClick;
            this.Shown += FrmCookbookDetails_Shown;
        }

        private void FrmCookbookDetails_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipes();
        }
        //FIGURE OUT WHY COOKBOOKUPDATE METHOD ISN'T WORKING

        public void LoadForm(int cookbookidval)
        {
            cookbookid = cookbookidval;
            this.Tag = cookbookid;
            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;
            if (cookbookid == 0)
            {
                dtcookbook.Rows.Add();
            }
            DataTable dtUser = Cookbook.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUser, dtUser, dtcookbook, "User");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(cbxIsActive, bindsource);
            //this.Text = 
        }

        private void LoadCookbookRecipes()
        {
            dtcookbookrecipe = CookbookRecipe.LoadByCookbookId(cookbookid);
            gRecipeData.Columns.Clear();
            gRecipeData.DataSource = dtcookbookrecipe;
            WindowsFormsUtility.AddComboBoxToGrid(gRecipeData, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipeData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gRecipeData, "CookbookRecipe");
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord();
                //this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
        }

        private void GRecipeData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRecipeSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FrmCookbookDetails_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //bindsource.EndEdit();
            //if (SQLUtility.TableHasChanges(dtcookbook))
            //{
            //    var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
            //    switch (res)
            //    {
            //        case DialogResult.Yes:
            //            bool b = Save();
            //            if (b == false)
            //            {
            //                e.Cancel = true;
            //                this.Activate();
            //            }
            //            break;
            //        case DialogResult.Cancel:
            //            e.Cancel = true;
            //            this.Activate();
            //            break;
            //    }
            //}
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
