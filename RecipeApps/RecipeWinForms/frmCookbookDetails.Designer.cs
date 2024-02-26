namespace RecipeWinForms
{
    partial class frmCookbookDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCookbookDetails));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCookbookName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtCookbookName = new System.Windows.Forms.TextBox();
            this.lstUser = new System.Windows.Forms.ComboBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tblPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.cbxIsActive = new System.Windows.Forms.CheckBox();
            this.tblRecipe = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecipeSave = new System.Windows.Forms.Button();
            this.gRecipeData = new System.Windows.Forms.DataGridView();
            this.tsMain.SuspendLayout();
            this.tblMain.SuspendLayout();
            this.tblPrice.SuspendLayout();
            this.tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeData)).BeginInit();
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
            this.toolStripSeparator2});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1100, 35);
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
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.lblCookbookName, 0, 0);
            this.tblMain.Controls.Add(this.lblUser, 0, 1);
            this.tblMain.Controls.Add(this.txtCookbookName, 1, 0);
            this.tblMain.Controls.Add(this.lstUser, 1, 1);
            this.tblMain.Controls.Add(this.lblIsActive, 0, 4);
            this.tblMain.Controls.Add(this.lblPrice, 0, 3);
            this.tblMain.Controls.Add(this.tblPrice, 1, 2);
            this.tblMain.Controls.Add(this.cbxIsActive, 1, 4);
            this.tblMain.Controls.Add(this.tblRecipe, 0, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 35);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tblMain.Size = new System.Drawing.Size(1100, 595);
            this.tblMain.TabIndex = 1;
            // 
            // lblCookbookName
            // 
            this.lblCookbookName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCookbookName.AutoSize = true;
            this.lblCookbookName.Location = new System.Drawing.Point(3, 6);
            this.lblCookbookName.Name = "lblCookbookName";
            this.lblCookbookName.Size = new System.Drawing.Size(161, 28);
            this.lblCookbookName.TabIndex = 0;
            this.lblCookbookName.Text = "Cookbook Name";
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
            // txtCookbookName
            // 
            this.txtCookbookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCookbookName.Location = new System.Drawing.Point(170, 3);
            this.txtCookbookName.Name = "txtCookbookName";
            this.txtCookbookName.Size = new System.Drawing.Size(927, 34);
            this.txtCookbookName.TabIndex = 4;
            // 
            // lstUser
            // 
            this.lstUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUser.FormattingEnabled = true;
            this.lstUser.Location = new System.Drawing.Point(170, 43);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(927, 36);
            this.lstUser.TabIndex = 5;
            // 
            // lblIsActive
            // 
            this.lblIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(3, 203);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(66, 28);
            this.lblIsActive.TabIndex = 3;
            this.lblIsActive.Text = "Active";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 148);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 28);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // tblPrice
            // 
            this.tblPrice.ColumnCount = 2;
            this.tblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.Controls.Add(this.lblDateCreated, 1, 0);
            this.tblPrice.Controls.Add(this.txtPrice, 0, 1);
            this.tblPrice.Controls.Add(this.txtDateCreated, 1, 1);
            this.tblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrice.Location = new System.Drawing.Point(170, 85);
            this.tblPrice.Name = "tblPrice";
            this.tblPrice.RowCount = 2;
            this.tblMain.SetRowSpan(this.tblPrice, 2);
            this.tblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.93617F));
            this.tblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.06383F));
            this.tblPrice.Size = new System.Drawing.Size(927, 102);
            this.tblPrice.TabIndex = 6;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(466, 0);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(458, 49);
            this.lblDateCreated.TabIndex = 0;
            this.lblDateCreated.Text = "Date Created:";
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(3, 52);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(457, 47);
            this.txtPrice.TabIndex = 1;
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateCreated.Location = new System.Drawing.Point(466, 52);
            this.txtDateCreated.Multiline = true;
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.Size = new System.Drawing.Size(458, 47);
            this.txtDateCreated.TabIndex = 2;
            this.txtDateCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxIsActive
            // 
            this.cbxIsActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxIsActive.AutoSize = true;
            this.cbxIsActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxIsActive.Location = new System.Drawing.Point(170, 208);
            this.cbxIsActive.Name = "cbxIsActive";
            this.cbxIsActive.Size = new System.Drawing.Size(18, 17);
            this.cbxIsActive.TabIndex = 7;
            this.cbxIsActive.UseVisualStyleBackColor = true;
            // 
            // tblRecipe
            // 
            this.tblRecipe.ColumnCount = 1;
            this.tblMain.SetColumnSpan(this.tblRecipe, 2);
            this.tblRecipe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipe.Controls.Add(this.btnRecipeSave, 0, 0);
            this.tblRecipe.Controls.Add(this.gRecipeData, 0, 1);
            this.tblRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecipe.Location = new System.Drawing.Point(3, 247);
            this.tblRecipe.Name = "tblRecipe";
            this.tblRecipe.RowCount = 2;
            this.tblRecipe.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblRecipe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipe.Size = new System.Drawing.Size(1094, 345);
            this.tblRecipe.TabIndex = 8;
            // 
            // btnRecipeSave
            // 
            this.btnRecipeSave.AutoSize = true;
            this.btnRecipeSave.Location = new System.Drawing.Point(3, 3);
            this.btnRecipeSave.Name = "btnRecipeSave";
            this.btnRecipeSave.Size = new System.Drawing.Size(94, 38);
            this.btnRecipeSave.TabIndex = 0;
            this.btnRecipeSave.Text = "Save";
            this.btnRecipeSave.UseVisualStyleBackColor = true;
            // 
            // gRecipeData
            // 
            this.gRecipeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeData.Location = new System.Drawing.Point(3, 47);
            this.gRecipeData.Name = "gRecipeData";
            this.gRecipeData.RowHeadersWidth = 51;
            this.gRecipeData.RowTemplate.Height = 29;
            this.gRecipeData.Size = new System.Drawing.Size(1088, 295);
            this.gRecipeData.TabIndex = 1;
            // 
            // frmCookbookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Controls.Add(this.tsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCookbookDetails";
            this.Text = "Cookbook Details";
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblPrice.ResumeLayout(false);
            this.tblPrice.PerformLayout();
            this.tblRecipe.ResumeLayout(false);
            this.tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private TableLayoutPanel tblMain;
        private Label lblCookbookName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtCookbookName;
        private ComboBox lstUser;
        private TableLayoutPanel tblPrice;
        private Label lblDateCreated;
        private TextBox txtPrice;
        private TextBox txtDateCreated;
        private CheckBox cbxIsActive;
        private TableLayoutPanel tblRecipe;
        private Button btnRecipeSave;
        private DataGridView gRecipeData;
        private Label lblIsActive;
    }
}