﻿namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDashboard_Click;
            mnuTile.Click += MnuTile_Click;
            mnuCascade.Click += MnuCascade_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCloneARecipe.Click += MnuCloneARecipe_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuAutoCreateCookbook.Click += MnuAutoCreateCookbook_Click;
            this.Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }


        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipeDetails))
                {
                    frmRecipeDetails f = new();
                    newfrm = f;
                    f.LoadRecipeForm(pkvalue);
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeClone))
                {
                    frmRecipeClone f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookDetails))
                {
                    frmCookbookDetails f = new();
                    newfrm = f;
                    f.LoadForm(pkvalue);
                }
                else if (frmtype == typeof(frmAutoCreateCookbook))
                {
                    frmAutoCreateCookbook f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    //frmRecipeDetails r = new();
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadChangeStatusForm(pkvalue);
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
                WindowsFormsUtility.SetupNav(tsMain);
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetupNav(tsMain);
        }
        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookDetails));
        }

        private void MnuAutoCreateCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeClone));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeDetails));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }
    }

}
