namespace RecipeWinForms
{
    partial class frmDataMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.gData = new System.Windows.Forms.DataGridView();
            this.pnlOptionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.optUser = new System.Windows.Forms.RadioButton();
            this.optCuisine = new System.Windows.Forms.RadioButton();
            this.optIngredient = new System.Windows.Forms.RadioButton();
            this.optMeasurement = new System.Windows.Forms.RadioButton();
            this.optCourse = new System.Windows.Forms.RadioButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.pnlOptionButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.btnSave, 1, 1);
            this.tblMain.Controls.Add(this.gData, 1, 0);
            this.tblMain.Controls.Add(this.pnlOptionButtons, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.49207F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.50794F));
            this.tblMain.Size = new System.Drawing.Size(1100, 630);
            this.tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1003, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 51);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(208, 3);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 51;
            this.gData.RowTemplate.Height = 29;
            this.gData.Size = new System.Drawing.Size(889, 457);
            this.gData.TabIndex = 1;
            // 
            // pnlOptionButtons
            // 
            this.pnlOptionButtons.AutoSize = true;
            this.pnlOptionButtons.Controls.Add(this.optUser);
            this.pnlOptionButtons.Controls.Add(this.optCuisine);
            this.pnlOptionButtons.Controls.Add(this.optIngredient);
            this.pnlOptionButtons.Controls.Add(this.optMeasurement);
            this.pnlOptionButtons.Controls.Add(this.optCourse);
            this.pnlOptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptionButtons.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlOptionButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlOptionButtons.Name = "pnlOptionButtons";
            this.tblMain.SetRowSpan(this.pnlOptionButtons, 2);
            this.pnlOptionButtons.Size = new System.Drawing.Size(199, 624);
            this.pnlOptionButtons.TabIndex = 2;
            // 
            // optUser
            // 
            this.optUser.AutoSize = true;
            this.optUser.Checked = true;
            this.optUser.Location = new System.Drawing.Point(3, 3);
            this.optUser.Name = "optUser";
            this.optUser.Size = new System.Drawing.Size(92, 36);
            this.optUser.TabIndex = 0;
            this.optUser.TabStop = true;
            this.optUser.Text = "Users";
            this.optUser.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            this.optCuisine.AutoSize = true;
            this.optCuisine.Location = new System.Drawing.Point(3, 45);
            this.optCuisine.Name = "optCuisine";
            this.optCuisine.Size = new System.Drawing.Size(181, 36);
            this.optCuisine.TabIndex = 1;
            this.optCuisine.Text = "Cuisine Types";
            this.optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            this.optIngredient.AutoSize = true;
            this.optIngredient.Location = new System.Drawing.Point(3, 87);
            this.optIngredient.Name = "optIngredient";
            this.optIngredient.Size = new System.Drawing.Size(155, 36);
            this.optIngredient.TabIndex = 2;
            this.optIngredient.Text = "Ingredients";
            this.optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            this.optMeasurement.AutoSize = true;
            this.optMeasurement.Location = new System.Drawing.Point(3, 129);
            this.optMeasurement.Name = "optMeasurement";
            this.optMeasurement.Size = new System.Drawing.Size(193, 36);
            this.optMeasurement.TabIndex = 3;
            this.optMeasurement.Text = "Measurements";
            this.optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            this.optCourse.AutoSize = true;
            this.optCourse.Location = new System.Drawing.Point(3, 171);
            this.optCourse.Name = "optCourse";
            this.optCourse.Size = new System.Drawing.Size(119, 36);
            this.optCourse.TabIndex = 4;
            this.optCourse.Text = "Courses";
            this.optCourse.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "frmDataMaintenance";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.pnlOptionButtons.ResumeLayout(false);
            this.pnlOptionButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlOptionButtons;
        private RadioButton optUser;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
    }
}