namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            this.btnCreateCookbook = new System.Windows.Forms.Button();
            this.lstMeasurement = new System.Windows.Forms.ComboBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.btnCreateCookbook, 1, 0);
            this.tblMain.Controls.Add(this.lstMeasurement, 0, 0);
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(1100, 630);
            this.tblMain.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            this.btnCreateCookbook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateCookbook.AutoSize = true;
            this.btnCreateCookbook.Location = new System.Drawing.Point(700, 290);
            this.btnCreateCookbook.Name = "btnCreateCookbook";
            this.btnCreateCookbook.Size = new System.Drawing.Size(250, 49);
            this.btnCreateCookbook.TabIndex = 1;
            this.btnCreateCookbook.Text = "Create Cookbook";
            this.btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // lstMeasurement
            // 
            this.lstMeasurement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstMeasurement.FormattingEnabled = true;
            this.lstMeasurement.Location = new System.Drawing.Point(123, 301);
            this.lstMeasurement.Name = "lstMeasurement";
            this.lstMeasurement.Size = new System.Drawing.Size(304, 36);
            this.lstMeasurement.TabIndex = 0;
            // 
            // frmAutoCreateCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAutoCreateCookbook";
            this.Text = "Auto-Create a Cookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstMeasurement;
        private Button btnCreateCookbook;
    }
}