using RecipeSystems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            this.Text = GetCookbookDesc();
            SetButtonsEnabledBasedOnNewRecord();
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
                this.Text = GetCookbookDesc();
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

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", "Cookbook", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnRecipeSave.Enabled = b;
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void SaveCookbookRecipe()
        {
            try
            {
                CookbookRecipe.SaveTable(dtcookbookrecipe, cookbookid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteCookbookRecipe(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipeData, rowindex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipeData.Rows.Count)
            {
                gRecipeData.Rows.RemoveAt(rowindex);
            }

        }


        private void GRecipeData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteCookbookRecipe(e.RowIndex);
        }
        private void BtnRecipeSave_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }

        private void FrmCookbookDetails_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
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
