using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        public void ShowRecipeForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
            }
        }
        public void ShowMealForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
            }
        }
        public void ShowCookbookForm()
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
            }
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm();
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowMealForm();
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm();
        }


    }
}
