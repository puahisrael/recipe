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
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
            this.Shown += FrmChangeStatus_Shown;
        }

        private void FrmChangeStatus_Shown(object? sender, EventArgs e)
        {
            DisableCurrentStatusButton();        }

        private void DisableCurrentStatusButton()
        {
            if(lblCurrentStatus.Text == "Draft")
            {
                btnDraft.Enabled = false;
            }
            else if(lblCurrentStatus.Text == "Published")
            {
                btnPublish.Enabled = false;
            }
            else if(lblCurrentStatus.Text == "Archived")
            {
                btnArchive.Enabled = false;
            }
        }

        private string GetFormDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value + " - Change Status";
        }

        public void LoadChangeStatusForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDraftDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPublishedDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtArchivedDate, bindsource);
            this.Text = GetFormDesc();
        }

        private void ChangeStatus(int recipeid, string newstatus)
        {
            var response = MessageBox.Show($"Are you sure you want to change this recipe to {newstatus}", lblRecipeName.Text, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.ChangeRecipeStatus(recipeid ,newstatus, dtrecipe);
                //change status - need sproc?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus(SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId"),"Draft");
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus(SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId"), "Archived");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus(SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId"), "Published");
        }
    }
}
