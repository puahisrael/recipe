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
            throw new NotImplementedException();
        }

        //loadform method

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
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
