namespace RecipeWinForms
{
    partial class frmRecipeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetails));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangeStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblNumCalories = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lstUsers = new System.Windows.Forms.ComboBox();
            this.lstCuisines = new System.Windows.Forms.ComboBox();
            this.txtNumCalories = new System.Windows.Forms.TextBox();
            this.txtCurrentStatus = new System.Windows.Forms.TextBox();
            this.tbChildControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tsMain.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbChildControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolStripSeparator1,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnChangeStatus,
            this.toolStripSeparator3});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(606, 35);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 32);
            this.btnSave.Text = "Save";
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
            this.btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnChangeStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChangeStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.Image")));
            this.btnChangeStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(140, 32);
            this.btnChangeStatus.Text = "Change Status";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblUser, 0, 1);
            this.tblMain.Controls.Add(this.lblCuisine, 0, 2);
            this.tblMain.Controls.Add(this.lblNumCalories, 0, 3);
            this.tblMain.Controls.Add(this.lblCurrentStatus, 0, 4);
            this.tblMain.Controls.Add(this.lblStatusDates, 0, 6);
            this.tblMain.Controls.Add(this.tableLayoutPanel1, 1, 5);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.lstUsers, 1, 1);
            this.tblMain.Controls.Add(this.lstCuisines, 1, 2);
            this.tblMain.Controls.Add(this.txtNumCalories, 1, 3);
            this.tblMain.Controls.Add(this.txtCurrentStatus, 1, 4);
            this.tblMain.Controls.Add(this.tbChildControls, 0, 7);
            this.tblMain.Location = new System.Drawing.Point(0, 38);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(606, 599);
            this.tblMain.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Location = new System.Drawing.Point(3, 6);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(126, 28);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(3, 47);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 28);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblCuisine
            // 
            this.lblCuisine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Location = new System.Drawing.Point(3, 89);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(74, 28);
            this.lblCuisine.TabIndex = 2;
            this.lblCuisine.Text = "Cuisine";
            // 
            // lblNumCalories
            // 
            this.lblNumCalories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumCalories.AutoSize = true;
            this.lblNumCalories.Location = new System.Drawing.Point(3, 130);
            this.lblNumCalories.Name = "lblNumCalories";
            this.lblNumCalories.Size = new System.Drawing.Size(129, 28);
            this.lblNumCalories.TabIndex = 3;
            this.lblNumCalories.Text = "Num Calories";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(3, 170);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(135, 28);
            this.lblCurrentStatus.TabIndex = 4;
            this.lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Location = new System.Drawing.Point(3, 274);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(119, 28);
            this.lblStatusDates.TabIndex = 5;
            this.lblStatusDates.Text = "Status Dates";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.68013F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.98653F));
            this.tableLayoutPanel1.Controls.Add(this.lblDrafted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblArchived, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPublished, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(306, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tblMain.SetRowSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 107);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblDrafted
            // 
            this.lblDrafted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(92, 53);
            this.lblDrafted.TabIndex = 0;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArchived.AutoSize = true;
            this.lblArchived.Location = new System.Drawing.Point(204, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(90, 53);
            this.lblArchived.TabIndex = 2;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublished.AutoSize = true;
            this.lblPublished.Location = new System.Drawing.Point(101, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(97, 53);
            this.lblPublished.TabIndex = 1;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(306, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(297, 34);
            this.txtRecipeName.TabIndex = 7;
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(306, 43);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(297, 36);
            this.lstUsers.TabIndex = 9;
            // 
            // lstCuisines
            // 
            this.lstCuisines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisines.FormattingEnabled = true;
            this.lstCuisines.Location = new System.Drawing.Point(306, 85);
            this.lstCuisines.Name = "lstCuisines";
            this.lstCuisines.Size = new System.Drawing.Size(297, 36);
            this.lstCuisines.TabIndex = 10;
            // 
            // txtNumCalories
            // 
            this.txtNumCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumCalories.Location = new System.Drawing.Point(306, 127);
            this.txtNumCalories.Name = "txtNumCalories";
            this.txtNumCalories.Size = new System.Drawing.Size(297, 34);
            this.txtNumCalories.TabIndex = 8;
            // 
            // txtCurrentStatus
            // 
            this.txtCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentStatus.Location = new System.Drawing.Point(306, 167);
            this.txtCurrentStatus.Name = "txtCurrentStatus";
            this.txtCurrentStatus.Size = new System.Drawing.Size(297, 34);
            this.txtCurrentStatus.TabIndex = 11;
            // 
            // tbChildControls
            // 
            this.tblMain.SetColumnSpan(this.tbChildControls, 2);
            this.tbChildControls.Controls.Add(this.tabPage1);
            this.tbChildControls.Controls.Add(this.tabPage2);
            this.tbChildControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChildControls.Location = new System.Drawing.Point(3, 320);
            this.tbChildControls.Name = "tbChildControls";
            this.tblMain.SetRowSpan(this.tbChildControls, 2);
            this.tbChildControls.SelectedIndex = 0;
            this.tbChildControls.Size = new System.Drawing.Size(600, 288);
            this.tbChildControls.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(289, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmRecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 640);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.tsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipeDetails";
            this.Text = "Recipe Details";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbChildControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnChangeStatus;
        private ToolStripSeparator toolStripSeparator3;
        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblUser;
        private Label lblCuisine;
        private Label lblNumCalories;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblDrafted;
        private Label lblArchived;
        private Label lblPublished;
        private TextBox txtRecipeName;
        private ComboBox lstUsers;
        private ComboBox lstCuisines;
        private TextBox txtNumCalories;
        private TextBox txtCurrentStatus;
        private TabControl tbChildControls;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}