﻿namespace RecipeWinForms
{
    partial class frmSearch
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
            this.tblSearch = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gRecipe = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.tblSearch, 0, 0);
            this.tblMain.Controls.Add(this.gRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(590, 665);
            this.tblMain.TabIndex = 0;
            // 
            // tblSearch
            // 
            this.tblSearch.ColumnCount = 4;
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.4697F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.5303F));
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tblSearch.Controls.Add(this.lblRecipe, 0, 0);
            this.tblSearch.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblSearch.Controls.Add(this.btnSearch, 2, 0);
            this.tblSearch.Controls.Add(this.btnNew, 3, 0);
            this.tblSearch.Location = new System.Drawing.Point(4, 4);
            this.tblSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tblSearch.Name = "tblSearch";
            this.tblSearch.RowCount = 1;
            this.tblSearch.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSearch.Size = new System.Drawing.Size(519, 49);
            this.tblSearch.TabIndex = 0;
            // 
            // lblRecipe
            // 
            this.lblRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(4, 10);
            this.lblRecipe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(69, 28);
            this.lblRecipe.TabIndex = 0;
            this.lblRecipe.Text = "Recipe";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRecipeName.Location = new System.Drawing.Point(100, 7);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(174, 34);
            this.txtRecipeName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(282, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gRecipe
            // 
            this.gRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipe.Location = new System.Drawing.Point(3, 60);
            this.gRecipe.Name = "gRecipe";
            this.gRecipe.RowHeadersWidth = 51;
            this.gRecipe.RowTemplate.Height = 29;
            this.gRecipe.Size = new System.Drawing.Size(584, 602);
            this.gRecipe.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.AutoSize = true;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(420, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 43);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 665);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearch";
            this.Text = "Recipe Search";
            this.tblMain.ResumeLayout(false);
            this.tblSearch.ResumeLayout(false);
            this.tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblSearch;
        private Label lblRecipe;
        private TextBox txtRecipeName;
        private Button btnSearch;
        private DataGridView gRecipe;
        private Button btnNew;
    }
}