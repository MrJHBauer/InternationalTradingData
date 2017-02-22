namespace InternationalTradingData
{
    partial class MainForm
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
            this.Title = new System.Windows.Forms.Label();
            this.LBox_Countries = new System.Windows.Forms.ListBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_GDP = new System.Windows.Forms.Label();
            this.Label_Inflation = new System.Windows.Forms.Label();
            this.Label_TradeBalance = new System.Windows.Forms.Label();
            this.Label_HDI = new System.Windows.Forms.Label();
            this.Label_MainTradingPartners = new System.Windows.Forms.Label();
            this.TBox_Name = new System.Windows.Forms.TextBox();
            this.TBox_GDP = new System.Windows.Forms.TextBox();
            this.TBox_Inflation = new System.Windows.Forms.TextBox();
            this.TBox_TradeBalance = new System.Windows.Forms.TextBox();
            this.TBox_HDI = new System.Windows.Forms.TextBox();
            this.TBox_MainTradingPartners = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(110, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(415, 37);
            this.Title.TabIndex = 0;
            this.Title.Text = "International Trading Data";
            // 
            // LBox_Countries
            // 
            this.LBox_Countries.FormattingEnabled = true;
            this.LBox_Countries.Location = new System.Drawing.Point(67, 71);
            this.LBox_Countries.Name = "LBox_Countries";
            this.LBox_Countries.Size = new System.Drawing.Size(120, 199);
            this.LBox_Countries.TabIndex = 1;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(299, 72);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name:";
            // 
            // Label_GDP
            // 
            this.Label_GDP.AutoSize = true;
            this.Label_GDP.Location = new System.Drawing.Point(213, 99);
            this.Label_GDP.Name = "Label_GDP";
            this.Label_GDP.Size = new System.Drawing.Size(124, 13);
            this.Label_GDP.TabIndex = 3;
            this.Label_GDP.Text = "Gross Domestic Product:";
            // 
            // Label_Inflation
            // 
            this.Label_Inflation.AutoSize = true;
            this.Label_Inflation.Location = new System.Drawing.Point(290, 126);
            this.Label_Inflation.Name = "Label_Inflation";
            this.Label_Inflation.Size = new System.Drawing.Size(47, 13);
            this.Label_Inflation.TabIndex = 4;
            this.Label_Inflation.Text = "Inflation:";
            // 
            // Label_TradeBalance
            // 
            this.Label_TradeBalance.AutoSize = true;
            this.Label_TradeBalance.Location = new System.Drawing.Point(257, 153);
            this.Label_TradeBalance.Name = "Label_TradeBalance";
            this.Label_TradeBalance.Size = new System.Drawing.Size(80, 13);
            this.Label_TradeBalance.TabIndex = 5;
            this.Label_TradeBalance.Text = "Trade Balance:";
            // 
            // Label_HDI
            // 
            this.Label_HDI.AutoSize = true;
            this.Label_HDI.Location = new System.Drawing.Point(198, 180);
            this.Label_HDI.Name = "Label_HDI";
            this.Label_HDI.Size = new System.Drawing.Size(139, 13);
            this.Label_HDI.TabIndex = 6;
            this.Label_HDI.Text = "Human Development Index:";
            // 
            // Label_MainTradingPartners
            // 
            this.Label_MainTradingPartners.AutoSize = true;
            this.Label_MainTradingPartners.Location = new System.Drawing.Point(223, 207);
            this.Label_MainTradingPartners.Name = "Label_MainTradingPartners";
            this.Label_MainTradingPartners.Size = new System.Drawing.Size(114, 13);
            this.Label_MainTradingPartners.TabIndex = 7;
            this.Label_MainTradingPartners.Text = "Main Trading Partners:";
            // 
            // TBox_Name
            // 
            this.TBox_Name.Location = new System.Drawing.Point(356, 69);
            this.TBox_Name.Name = "TBox_Name";
            this.TBox_Name.Size = new System.Drawing.Size(159, 20);
            this.TBox_Name.TabIndex = 8;
            // 
            // TBox_GDP
            // 
            this.TBox_GDP.Location = new System.Drawing.Point(356, 96);
            this.TBox_GDP.Name = "TBox_GDP";
            this.TBox_GDP.Size = new System.Drawing.Size(159, 20);
            this.TBox_GDP.TabIndex = 9;
            // 
            // TBox_Inflation
            // 
            this.TBox_Inflation.Location = new System.Drawing.Point(356, 123);
            this.TBox_Inflation.Name = "TBox_Inflation";
            this.TBox_Inflation.Size = new System.Drawing.Size(159, 20);
            this.TBox_Inflation.TabIndex = 10;
            // 
            // TBox_TradeBalance
            // 
            this.TBox_TradeBalance.Location = new System.Drawing.Point(356, 150);
            this.TBox_TradeBalance.Name = "TBox_TradeBalance";
            this.TBox_TradeBalance.Size = new System.Drawing.Size(159, 20);
            this.TBox_TradeBalance.TabIndex = 11;
            // 
            // TBox_HDI
            // 
            this.TBox_HDI.Location = new System.Drawing.Point(356, 177);
            this.TBox_HDI.Name = "TBox_HDI";
            this.TBox_HDI.Size = new System.Drawing.Size(159, 20);
            this.TBox_HDI.TabIndex = 12;
            // 
            // TBox_MainTradingPartners
            // 
            this.TBox_MainTradingPartners.Location = new System.Drawing.Point(356, 204);
            this.TBox_MainTradingPartners.Name = "TBox_MainTradingPartners";
            this.TBox_MainTradingPartners.Size = new System.Drawing.Size(159, 20);
            this.TBox_MainTradingPartners.TabIndex = 13;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(356, 247);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 14;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(440, 247);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 15;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.TBox_MainTradingPartners);
            this.Controls.Add(this.TBox_HDI);
            this.Controls.Add(this.TBox_TradeBalance);
            this.Controls.Add(this.TBox_Inflation);
            this.Controls.Add(this.TBox_GDP);
            this.Controls.Add(this.TBox_Name);
            this.Controls.Add(this.Label_MainTradingPartners);
            this.Controls.Add(this.Label_HDI);
            this.Controls.Add(this.Label_TradeBalance);
            this.Controls.Add(this.Label_Inflation);
            this.Controls.Add(this.Label_GDP);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.LBox_Countries);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "International Trading Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox LBox_Countries;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_GDP;
        private System.Windows.Forms.Label Label_Inflation;
        private System.Windows.Forms.Label Label_TradeBalance;
        private System.Windows.Forms.Label Label_HDI;
        private System.Windows.Forms.Label Label_MainTradingPartners;
        private System.Windows.Forms.TextBox TBox_Name;
        private System.Windows.Forms.TextBox TBox_GDP;
        private System.Windows.Forms.TextBox TBox_Inflation;
        private System.Windows.Forms.TextBox TBox_TradeBalance;
        private System.Windows.Forms.TextBox TBox_HDI;
        private System.Windows.Forms.TextBox TBox_MainTradingPartners;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
    }
}