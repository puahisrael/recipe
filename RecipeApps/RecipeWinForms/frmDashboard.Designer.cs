namespace RecipeWinForms
{
    partial class frmDashboard
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.gData = new System.Windows.Forms.DataGridView();
            this.tblShortcuts = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecipeList = new System.Windows.Forms.Button();
            this.btnMealList = new System.Windows.Forms.Button();
            this.btnCookbookList = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.tblShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblMain.Controls.Add(this.lblHeader, 1, 0);
            this.tblMain.Controls.Add(this.lblDesc, 1, 1);
            this.tblMain.Controls.Add(this.gData, 1, 2);
            this.tblMain.Controls.Add(this.tblShortcuts, 1, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.31844F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.03297F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.75092F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tblMain.Size = new System.Drawing.Size(1100, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(168, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(764, 94);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Hearty Hearth Desktop App";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Location = new System.Drawing.Point(168, 94);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(764, 93);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and " +
    "cookbooks. You can also...";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(168, 190);
            this.gData.Name = "gData";
            this.gData.RowHeadersWidth = 51;
            this.gData.RowTemplate.Height = 29;
            this.gData.Size = new System.Drawing.Size(764, 353);
            this.gData.TabIndex = 2;
            // 
            // tblShortcuts
            // 
            this.tblShortcuts.ColumnCount = 3;
            this.tblShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblShortcuts.Controls.Add(this.btnRecipeList, 0, 0);
            this.tblShortcuts.Controls.Add(this.btnMealList, 1, 0);
            this.tblShortcuts.Controls.Add(this.btnCookbookList, 2, 0);
            this.tblShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblShortcuts.Location = new System.Drawing.Point(168, 549);
            this.tblShortcuts.Name = "tblShortcuts";
            this.tblShortcuts.RowCount = 1;
            this.tblShortcuts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblShortcuts.Size = new System.Drawing.Size(764, 78);
            this.tblShortcuts.TabIndex = 3;
            // 
            // btnRecipeList
            // 
            this.btnRecipeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecipeList.Location = new System.Drawing.Point(3, 3);
            this.btnRecipeList.Name = "btnRecipeList";
            this.btnRecipeList.Size = new System.Drawing.Size(248, 72);
            this.btnRecipeList.TabIndex = 0;
            this.btnRecipeList.Text = "Recipe List";
            this.btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            this.btnMealList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMealList.Location = new System.Drawing.Point(257, 3);
            this.btnMealList.Name = "btnMealList";
            this.btnMealList.Size = new System.Drawing.Size(248, 72);
            this.btnMealList.TabIndex = 1;
            this.btnMealList.Text = "Meal List";
            this.btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            this.btnCookbookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCookbookList.Location = new System.Drawing.Point(511, 3);
            this.btnCookbookList.Name = "btnCookbookList";
            this.btnCookbookList.Size = new System.Drawing.Size(250, 72);
            this.btnCookbookList.TabIndex = 2;
            this.btnCookbookList.Text = "Cookbook List";
            this.btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.tblShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeader;
        private Label lblDesc;
        private DataGridView gData;
        private TableLayoutPanel tblShortcuts;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
    }
}