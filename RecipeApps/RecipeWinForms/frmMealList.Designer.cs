namespace RecipeWinForms
{
    partial class frmMealList
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
            this.gMealData = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gMealData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.gMealData, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 1;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Size = new System.Drawing.Size(800, 450);
            this.tblMain.TabIndex = 0;
            // 
            // gMealData
            // 
            this.gMealData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gMealData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMealData.Location = new System.Drawing.Point(3, 3);
            this.gMealData.Name = "gMealData";
            this.gMealData.RowHeadersWidth = 51;
            this.gMealData.RowTemplate.Height = 29;
            this.gMealData.Size = new System.Drawing.Size(794, 444);
            this.gMealData.TabIndex = 0;
            // 
            // frmMealList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMealList";
            this.Text = "frmMealList";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gMealData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gMealData;
    }
}