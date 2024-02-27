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
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            //was so simple here - see if could also do it it this simple by changestatus form
            DataTable dtUser = Recipe.GetUserList();
            WindowsFormsUtility.SetListBinding(lstUser, dtUser, dtUser, "User");
        }
        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {

        }

    }
}
