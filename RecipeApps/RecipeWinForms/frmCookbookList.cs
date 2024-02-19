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
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmCookbookList_Activated;
            gCookbookData.CellDoubleClick += GCookbookData_CellDoubleClick;
            btnNewCookbook.Click += BtnNewCookbook_Click;
        }


        private void BindData()
        {
            DataTable dt = Cookbook.GetCookbookList();
            gCookbookData.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookData, "Cookbook");
            gCookbookData.Columns["CookbookId"].Visible = false;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gCookbookData, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetails), id);
            }
        }
      
        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

        private void GCookbookData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);

        }
    }
}
