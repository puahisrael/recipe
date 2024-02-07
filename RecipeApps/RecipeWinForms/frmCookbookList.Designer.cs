namespace RecipeWinForms
{
    partial class frmCookbookList
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
            this.btnNewCookbook = new System.Windows.Forms.Button();
            this.gCookbookData = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCookbookData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.btnNewCookbook, 0, 0);
            this.tblMain.Controls.Add(this.gCookbookData, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(1100, 630);
            this.tblMain.TabIndex = 0;
            // 
            // btnNewCookbook
            // 
            this.btnNewCookbook.AutoSize = true;
            this.btnNewCookbook.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewCookbook.Location = new System.Drawing.Point(3, 3);
            this.btnNewCookbook.Name = "btnNewCookbook";
            this.btnNewCookbook.Size = new System.Drawing.Size(216, 48);
            this.btnNewCookbook.TabIndex = 0;
            this.btnNewCookbook.Text = "New Cookbook";
            this.btnNewCookbook.UseVisualStyleBackColor = true;
            // 
            // gCookbookData
            // 
            this.gCookbookData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gCookbookData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCookbookData.Location = new System.Drawing.Point(3, 57);
            this.gCookbookData.Name = "gCookbookData";
            this.gCookbookData.RowHeadersWidth = 51;
            this.gCookbookData.RowTemplate.Height = 29;
            this.gCookbookData.Size = new System.Drawing.Size(1094, 570);
            this.gCookbookData.TabIndex = 1;
            // 
            // frmCookbookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCookbookList";
            this.Text = "Cookbook List";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCookbookData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnNewCookbook;
        private DataGridView gCookbookData;
    }
}