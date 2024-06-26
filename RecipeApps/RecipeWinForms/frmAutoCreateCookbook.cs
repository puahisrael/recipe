﻿using RecipeSystems;
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
            WindowsFormsUtility.SetListBinding(lstUser, DataMaintenance.GetDataList("User", true), null, "User");
        }

        private void CreateCookbook()
        {
            int userid = WindowsFormsUtility.GetIdFromComboBox(lstUser);
            int id;
            Cursor = Cursors.WaitCursor;
            try
            {
                Cookbook.AutoCreateCookbook(userid);
                //FIGURE OUT HOW TO LOAD NEW RECIPE FORM, NOT THE ONE THAT IT WAS CLONED FROM
                id = WindowsFormsUtility.GetIdFromComboBox(lstUser);
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetails), id);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            CreateCookbook();
        }

    }
}
