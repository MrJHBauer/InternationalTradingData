﻿namespace InternationalTradingData
{
    partial class SearchCountryForm
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
            this.DGridView_Countries = new System.Windows.Forms.DataGridView();
            this.Label_Name = new System.Windows.Forms.Label();
            this.TBox_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Countries)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridView_Countries
            // 
            this.DGridView_Countries.AllowUserToAddRows = false;
            this.DGridView_Countries.AllowUserToDeleteRows = false;
            this.DGridView_Countries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridView_Countries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridView_Countries.Location = new System.Drawing.Point(12, 58);
            this.DGridView_Countries.MultiSelect = false;
            this.DGridView_Countries.Name = "DGridView_Countries";
            this.DGridView_Countries.ReadOnly = true;
            this.DGridView_Countries.RowHeadersVisible = false;
            this.DGridView_Countries.Size = new System.Drawing.Size(680, 284);
            this.DGridView_Countries.TabIndex = 0;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(12, 21);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(77, 13);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "Country Name:";
            // 
            // TBox_Search
            // 
            this.TBox_Search.Location = new System.Drawing.Point(95, 18);
            this.TBox_Search.Name = "TBox_Search";
            this.TBox_Search.Size = new System.Drawing.Size(207, 20);
            this.TBox_Search.TabIndex = 4;
            this.TBox_Search.TextChanged += new System.EventHandler(this.TBox_Search_TextChanged);
            // 
            // SearchCountryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 351);
            this.Controls.Add(this.TBox_Search);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.DGridView_Countries);
            this.Name = "SearchCountryForm";
            this.Text = "Search For Country";
            ((System.ComponentModel.ISupportInitialize)(this.DGridView_Countries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridView_Countries;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.TextBox TBox_Search;
    }
}