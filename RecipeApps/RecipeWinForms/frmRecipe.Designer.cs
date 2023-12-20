namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaptionDraftDate = new System.Windows.Forms.Label();
            this.lblCaptionPublishedDate = new System.Windows.Forms.Label();
            this.lblCaptionArchvedDate = new System.Windows.Forms.Label();
            this.lblCaptionCalories = new System.Windows.Forms.Label();
            this.txtDraftDate = new System.Windows.Forms.TextBox();
            this.txtPublishedDate = new System.Windows.Forms.TextBox();
            this.txtArchivedDate = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblCaptionRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblCaptionStaff = new System.Windows.Forms.Label();
            this.lblCaptionCuisineType = new System.Windows.Forms.Label();
            this.lstLastName = new System.Windows.Forms.ComboBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.AutoSize = true;
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblCaptionDraftDate, 0, 3);
            this.tblMain.Controls.Add(this.lblCaptionPublishedDate, 0, 4);
            this.tblMain.Controls.Add(this.lblCaptionArchvedDate, 0, 5);
            this.tblMain.Controls.Add(this.lblCaptionCalories, 0, 6);
            this.tblMain.Controls.Add(this.txtDraftDate, 1, 3);
            this.tblMain.Controls.Add(this.txtPublishedDate, 1, 4);
            this.tblMain.Controls.Add(this.txtArchivedDate, 1, 5);
            this.tblMain.Controls.Add(this.txtCalories, 1, 6);
            this.tblMain.Controls.Add(this.lblCaptionRecipeName, 0, 2);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 2);
            this.tblMain.Controls.Add(this.lblCaptionStaff, 0, 0);
            this.tblMain.Controls.Add(this.lblCaptionCuisineType, 0, 1);
            this.tblMain.Controls.Add(this.lstLastName, 1, 0);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 1);
            this.tblMain.Location = new System.Drawing.Point(0, 46);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 7;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.306189F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.491857F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.469055F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.7329F));
            this.tblMain.Size = new System.Drawing.Size(606, 696);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaptionDraftDate
            // 
            this.lblCaptionDraftDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionDraftDate.AutoSize = true;
            this.lblCaptionDraftDate.Location = new System.Drawing.Point(4, 139);
            this.lblCaptionDraftDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionDraftDate.Name = "lblCaptionDraftDate";
            this.lblCaptionDraftDate.Size = new System.Drawing.Size(102, 28);
            this.lblCaptionDraftDate.TabIndex = 0;
            this.lblCaptionDraftDate.Text = "Draft Date";
            // 
            // lblCaptionPublishedDate
            // 
            this.lblCaptionPublishedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionPublishedDate.AutoSize = true;
            this.lblCaptionPublishedDate.Location = new System.Drawing.Point(4, 184);
            this.lblCaptionPublishedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionPublishedDate.Name = "lblCaptionPublishedDate";
            this.lblCaptionPublishedDate.Size = new System.Drawing.Size(143, 28);
            this.lblCaptionPublishedDate.TabIndex = 1;
            this.lblCaptionPublishedDate.Text = "Published Date";
            // 
            // lblCaptionArchvedDate
            // 
            this.lblCaptionArchvedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionArchvedDate.AutoSize = true;
            this.lblCaptionArchvedDate.Location = new System.Drawing.Point(4, 228);
            this.lblCaptionArchvedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaptionArchvedDate.Name = "lblCaptionArchvedDate";
            this.lblCaptionArchvedDate.Size = new System.Drawing.Size(135, 28);
            this.lblCaptionArchvedDate.TabIndex = 2;
            this.lblCaptionArchvedDate.Text = "Archived Date";
            // 
            // lblCaptionCalories
            // 
            this.lblCaptionCalories.AutoSize = true;
            this.lblCaptionCalories.Location = new System.Drawing.Point(4, 273);
            this.lblCaptionCalories.Margin = new System.Windows.Forms.Padding(4, 7, 4, 0);
            this.lblCaptionCalories.Name = "lblCaptionCalories";
            this.lblCaptionCalories.Size = new System.Drawing.Size(81, 28);
            this.lblCaptionCalories.TabIndex = 3;
            this.lblCaptionCalories.Text = "Calories";
            // 
            // txtDraftDate
            // 
            this.txtDraftDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDraftDate.Location = new System.Drawing.Point(306, 133);
            this.txtDraftDate.Name = "txtDraftDate";
            this.txtDraftDate.Size = new System.Drawing.Size(297, 34);
            this.txtDraftDate.TabIndex = 4;
            // 
            // txtPublishedDate
            // 
            this.txtPublishedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublishedDate.Location = new System.Drawing.Point(306, 180);
            this.txtPublishedDate.Name = "txtPublishedDate";
            this.txtPublishedDate.Size = new System.Drawing.Size(297, 34);
            this.txtPublishedDate.TabIndex = 5;
            // 
            // txtArchivedDate
            // 
            this.txtArchivedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArchivedDate.Location = new System.Drawing.Point(306, 222);
            this.txtArchivedDate.Name = "txtArchivedDate";
            this.txtArchivedDate.Size = new System.Drawing.Size(297, 34);
            this.txtArchivedDate.TabIndex = 6;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(306, 273);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(297, 34);
            this.txtCalories.TabIndex = 7;
            // 
            // lblCaptionRecipeName
            // 
            this.lblCaptionRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionRecipeName.AutoSize = true;
            this.lblCaptionRecipeName.Location = new System.Drawing.Point(3, 95);
            this.lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            this.lblCaptionRecipeName.Size = new System.Drawing.Size(126, 28);
            this.lblCaptionRecipeName.TabIndex = 8;
            this.lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(306, 91);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(297, 34);
            this.txtRecipeName.TabIndex = 9;
            // 
            // lblCaptionStaff
            // 
            this.lblCaptionStaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionStaff.AutoSize = true;
            this.lblCaptionStaff.Location = new System.Drawing.Point(3, 7);
            this.lblCaptionStaff.Name = "lblCaptionStaff";
            this.lblCaptionStaff.Size = new System.Drawing.Size(51, 28);
            this.lblCaptionStaff.TabIndex = 10;
            this.lblCaptionStaff.Text = "Staff";
            // 
            // lblCaptionCuisineType
            // 
            this.lblCaptionCuisineType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCaptionCuisineType.AutoSize = true;
            this.lblCaptionCuisineType.Location = new System.Drawing.Point(3, 51);
            this.lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            this.lblCaptionCuisineType.Size = new System.Drawing.Size(74, 28);
            this.lblCaptionCuisineType.TabIndex = 11;
            this.lblCaptionCuisineType.Text = "Cuisine";
            // 
            // lstLastName
            // 
            this.lstLastName.FormattingEnabled = true;
            this.lstLastName.Location = new System.Drawing.Point(306, 3);
            this.lstLastName.Name = "lstLastName";
            this.lstLastName.Size = new System.Drawing.Size(151, 36);
            this.lstLastName.TabIndex = 12;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(306, 46);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(151, 36);
            this.lstCuisineType.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 32);
            this.btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 32);
            this.btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 640);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionDraftDate;
        private Label lblCaptionPublishedDate;
        private Label lblCaptionArchvedDate;
        private Label lblCaptionCalories;
        private TextBox txtDraftDate;
        private TextBox txtPublishedDate;
        private TextBox txtArchivedDate;
        private TextBox txtCalories;
        private Label lblCaptionRecipeName;
        private TextBox txtRecipeName;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private Label lblCaptionStaff;
        private Label lblCaptionCuisineType;
        private ComboBox lstLastName;
        private ComboBox lstCuisineType;
    }
}