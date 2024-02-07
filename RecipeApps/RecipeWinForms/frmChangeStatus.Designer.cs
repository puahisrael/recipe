﻿namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.tblCurrentStatus = new System.Windows.Forms.TableLayoutPanel();
            this.tblStatusDates = new System.Windows.Forms.TableLayoutPanel();
            this.tblChangeStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblCurrentStatusType = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblCurrentStatus.SuspendLayout();
            this.tblStatusDates.SuspendLayout();
            this.tblChangeStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.tblCurrentStatus, 0, 1);
            this.tblMain.Controls.Add(this.tblStatusDates, 0, 2);
            this.tblMain.Controls.Add(this.tblChangeStatus, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Size = new System.Drawing.Size(1100, 630);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(1094, 157);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblCurrentStatus
            // 
            this.tblCurrentStatus.ColumnCount = 2;
            this.tblCurrentStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrentStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCurrentStatus.Controls.Add(this.lblCurrentStatusType, 1, 0);
            this.tblCurrentStatus.Controls.Add(this.lblCurrentStatus, 0, 0);
            this.tblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCurrentStatus.Location = new System.Drawing.Point(3, 160);
            this.tblCurrentStatus.Name = "tblCurrentStatus";
            this.tblCurrentStatus.RowCount = 1;
            this.tblCurrentStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCurrentStatus.Size = new System.Drawing.Size(1094, 151);
            this.tblCurrentStatus.TabIndex = 1;
            // 
            // tblStatusDates
            // 
            this.tblStatusDates.ColumnCount = 4;
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStatusDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblStatusDates.Controls.Add(this.lblStatusDates, 0, 1);
            this.tblStatusDates.Controls.Add(this.lblDrafted, 1, 0);
            this.tblStatusDates.Controls.Add(this.lblPublished, 2, 0);
            this.tblStatusDates.Controls.Add(this.lblArchived, 3, 0);
            this.tblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusDates.Location = new System.Drawing.Point(3, 317);
            this.tblStatusDates.Name = "tblStatusDates";
            this.tblStatusDates.RowCount = 2;
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatusDates.Size = new System.Drawing.Size(1094, 151);
            this.tblStatusDates.TabIndex = 2;
            // 
            // tblChangeStatus
            // 
            this.tblChangeStatus.ColumnCount = 7;
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblChangeStatus.Controls.Add(this.btnDraft, 1, 1);
            this.tblChangeStatus.Controls.Add(this.btnPublish, 3, 1);
            this.tblChangeStatus.Controls.Add(this.btnArchive, 5, 1);
            this.tblChangeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChangeStatus.Location = new System.Drawing.Point(3, 474);
            this.tblChangeStatus.Name = "tblChangeStatus";
            this.tblChangeStatus.RowCount = 2;
            this.tblChangeStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChangeStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChangeStatus.Size = new System.Drawing.Size(1094, 153);
            this.tblChangeStatus.TabIndex = 3;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStatus.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(541, 151);
            this.lblCurrentStatus.TabIndex = 0;
            this.lblCurrentStatus.Text = "Current Status:  ";
            this.lblCurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentStatusType
            // 
            this.lblCurrentStatusType.AutoSize = true;
            this.lblCurrentStatusType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatusType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStatusType.Location = new System.Drawing.Point(550, 0);
            this.lblCurrentStatusType.Name = "lblCurrentStatusType";
            this.lblCurrentStatusType.Size = new System.Drawing.Size(541, 151);
            this.lblCurrentStatusType.TabIndex = 0;
            this.lblCurrentStatusType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusDates.Location = new System.Drawing.Point(3, 75);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(267, 76);
            this.lblStatusDates.TabIndex = 0;
            this.lblStatusDates.Text = "Status Dates";
            this.lblStatusDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Location = new System.Drawing.Point(276, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(267, 75);
            this.lblDrafted.TabIndex = 1;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Location = new System.Drawing.Point(549, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(267, 75);
            this.lblPublished.TabIndex = 2;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Location = new System.Drawing.Point(822, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(269, 75);
            this.lblArchived.TabIndex = 3;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDraft
            // 
            this.btnDraft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDraft.Location = new System.Drawing.Point(159, 79);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(150, 71);
            this.btnDraft.TabIndex = 0;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPublish.Location = new System.Drawing.Point(471, 79);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(150, 71);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArchive.Location = new System.Drawing.Point(783, 79);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(150, 71);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblCurrentStatus.ResumeLayout(false);
            this.tblCurrentStatus.PerformLayout();
            this.tblStatusDates.ResumeLayout(false);
            this.tblStatusDates.PerformLayout();
            this.tblChangeStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatusType;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblStatusDates;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TableLayoutPanel tblChangeStatus;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}