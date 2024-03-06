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
            WindowsFormsUtility.SetListBinding(lstMeasurement, DataMaintenance.GetDataList("Measurement", true), null, "Measurement");
        }

        private void CreateCookbook()
        {
            int Measurementid = WindowsFormsUtility.GetIdFromComboBox(lstMeasurement);
            string cookbookname = $"Recipes by {lstMeasurement.DisplayMember}";
            //int price = 
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {

        }

    }
}
