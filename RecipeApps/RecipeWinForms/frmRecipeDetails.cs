using RecipeSystems;

namespace RecipeWinForms
{
    public partial class frmRecipeDetails : Form 
    {
        DataTable dtrecipe = new();
        DataTable dtrecipeingredient = new();
        DataTable dtrecipedirection = new();
        BindingSource bindsource = new BindingSource();
        string deletecolname = "deletecol";
        int recipeid = 0;

        public frmRecipeDetails()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            this.FormClosing += FrmRecipeDetails_FormClosing;
            btnIngredientSave.Click += BtnIngredientSave_Click;
            btnDirectionSave.Click += BtnStepSave_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredientData.CellContentClick += GIngredientData_CellContentClick;
            gDirectionData.CellContentClick += GStepData_CellContentClick;
            this.Shown += FrmRecipeDetails_Shown;
        }

        private void FrmRecipeDetails_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredients();
            LoadRecipeDirections();
        }

        public void LoadRecipeForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            if (recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtUser = Recipe.GetUserList();
            DataTable dtCuisine = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstUser, dtUser, dtrecipe, "User");
            WindowsFormsUtility.SetListBinding(lstCuisine, dtCuisine, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCurrentStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDraftDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtPublishedDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtArchivedDate, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            this.Text = GetRecipeDesc();
        }

        private void OpenChangeStatusForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                    f.LoadChangeStatusForm(pkvalue);
                }
                if (newfrm != null)
                {
                    newfrm.MdiParent = frmMain.ActiveForm;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged; ;
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

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gIngredientData.Columns.Clear();
            gIngredientData.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredientData, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredientData, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasurementTypeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredientData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredientData, "RecipeIngredient");
        }

        private void LoadRecipeDirections()
        {
            dtrecipedirection = RecipeDirection.LoadByRecipeId(recipeid);
            gDirectionData.Columns.Clear();
            gDirectionData.DataSource = dtrecipedirection;
            WindowsFormsUtility.AddDeleteButtonToGrid(gDirectionData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredientData, "RecipeIngredient");

        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtrecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void SaveRecipeIngredient()
        {
            try
            {
                RecipeIngredient.SaveTable(dtrecipeingredient, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredientData, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gIngredientData.Rows.Count)
            {
                gIngredientData.Rows.RemoveAt(rowindex);
            }

        }

        private void SaveRecipeDirection()
        {
            try
            {
                RecipeDirection.SaveTable(dtrecipedirection, recipeid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }

        }

        private void DeleteRecipeDirection(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gDirectionData, rowindex, "RecipeDirectionId");
            if (id > 0)
            {
                try
                {
                    RecipeDirection.Delete(id);
                    LoadRecipeDirections();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gDirectionData.Rows.Count)
            {
                gDirectionData.Rows.RemoveAt(rowindex);
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this recipe?", "Recipe", MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnIngredientSave.Enabled = b;
            btnDirectionSave.Enabled = b;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void GStepData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeDirection(e.RowIndex);
        }

        private void GIngredientData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipeIngredient(e.RowIndex);
        }

        private void BtnStepSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirection();
        }

        private void BtnIngredientSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            OpenChangeStatusForm(typeof(frmChangeStatus));
        }

        private void FrmRecipeDetails_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
    }
}
