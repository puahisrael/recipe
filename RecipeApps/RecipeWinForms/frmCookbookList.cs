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
    }
}
