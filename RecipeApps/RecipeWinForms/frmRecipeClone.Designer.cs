namespace RecipeWinForms
{
    partial class frmRecipeClone
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
            this.lstRecipes = new System.Windows.Forms.ComboBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.btnClone, 0, 1);
            this.tblMain.Controls.Add(this.lstRecipes, 0, 0);
            this.tblMain.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tblMain.Location = new System.Drawing.Point(247, 96);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(352, 215);
            this.tblMain.TabIndex = 0;
            // 
            // lstRecipes
            // 
            this.lstRecipes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(3, 36);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(245, 45);
            this.lstRecipes.TabIndex = 0;
            // 
            // btnClone
            // 
            this.btnClone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClone.AutoSize = true;
            this.btnClone.Location = new System.Drawing.Point(103, 137);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(145, 47);
            this.btnClone.TabIndex = 1;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            // 
            // frmRecipeClone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipeClone";
            this.Text = "frmRecipeClone";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnClone;
        private ComboBox lstRecipes;
    }
}