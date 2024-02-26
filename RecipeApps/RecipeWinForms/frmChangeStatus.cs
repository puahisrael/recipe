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
        DataTable dtrecipestatus = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmChangeStatus()
        {
            InitializeComponent();
        }

        public void LoadChangeStatusForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipestatus = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipestatus;
            if (recipeid == 0)
            {
                dtrecipestatus.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(lblCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDraftDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPublishedDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtArchivedDate, bindsource);
            //this.Text = GetRecipeDesc();
        }
    }
}
