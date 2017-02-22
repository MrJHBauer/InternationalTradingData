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
            this.Label_MainTradePartners = new System.Windows.Forms.Label();
            this.TBox_Name = new System.Windows.Forms.TextBox();
            this.TBox_GDP = new System.Windows.Forms.TextBox();
            this.TBox_Inflation = new System.Windows.Forms.TextBox();
            this.TBox_TradeBalance = new System.Windows.Forms.TextBox();
            this.TBox_HDI = new System.Windows.Forms.TextBox();
            this.TBox_MainTradePartners = new System.Windows.Forms.TextBox();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Label_N_Countries = new System.Windows.Forms.Label();
            this.Label_Height = new System.Windows.Forms.Label();
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
            this.LBox_Countries.SelectedIndexChanged += new System.EventHandler(this.LBox_Countries_SelectedIndexChanged);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(302, 72);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(38, 13);
            this.Label_Name.TabIndex = 2;
            this.Label_Name.Text = "Name:";
            // 
            // Label_GDP
            // 
            this.Label_GDP.AutoSize = true;
            this.Label_GDP.Location = new System.Drawing.Point(216, 99);
            this.Label_GDP.Name = "Label_GDP";
            this.Label_GDP.Size = new System.Drawing.Size(124, 13);
            this.Label_GDP.TabIndex = 3;
            this.Label_GDP.Text = "Gross Domestic Product:";
            // 
            // Label_Inflation
            // 
            this.Label_Inflation.AutoSize = true;
            this.Label_Inflation.Location = new System.Drawing.Point(293, 126);
            this.Label_Inflation.Name = "Label_Inflation";
            this.Label_Inflation.Size = new System.Drawing.Size(47, 13);
            this.Label_Inflation.TabIndex = 4;
            this.Label_Inflation.Text = "Inflation:";
            // 
            // Label_TradeBalance
            // 
            this.Label_TradeBalance.AutoSize = true;
            this.Label_TradeBalance.Location = new System.Drawing.Point(260, 153);
            this.Label_TradeBalance.Name = "Label_TradeBalance";
            this.Label_TradeBalance.Size = new System.Drawing.Size(80, 13);
            this.Label_TradeBalance.TabIndex = 5;
            this.Label_TradeBalance.Text = "Trade Balance:";
            // 
            // Label_HDI
            // 
            this.Label_HDI.AutoSize = true;
            this.Label_HDI.Location = new System.Drawing.Point(201, 180);
            this.Label_HDI.Name = "Label_HDI";
            this.Label_HDI.Size = new System.Drawing.Size(139, 13);
            this.Label_HDI.TabIndex = 6;
            this.Label_HDI.Text = "Human Development Index:";
            // 
            // Label_MainTradePartners
            // 
            this.Label_MainTradePartners.AutoSize = true;
            this.Label_MainTradePartners.Location = new System.Drawing.Point(234, 207);
            this.Label_MainTradePartners.Name = "Label_MainTradePartners";
            this.Label_MainTradePartners.Size = new System.Drawing.Size(106, 13);
            this.Label_MainTradePartners.TabIndex = 7;
            this.Label_MainTradePartners.Text = "Main Trade Partners:";
            // 
            // TBox_Name
            // 
            this.TBox_Name.Enabled = false;
            this.TBox_Name.Location = new System.Drawing.Point(356, 69);
            this.TBox_Name.Name = "TBox_Name";
            this.TBox_Name.Size = new System.Drawing.Size(159, 20);
            this.TBox_Name.TabIndex = 8;
            // 
            // TBox_GDP
            // 
            this.TBox_GDP.Enabled = false;
            this.TBox_GDP.Location = new System.Drawing.Point(356, 96);
            this.TBox_GDP.Name = "TBox_GDP";
            this.TBox_GDP.Size = new System.Drawing.Size(159, 20);
            this.TBox_GDP.TabIndex = 9;
            // 
            // TBox_Inflation
            // 
            this.TBox_Inflation.Enabled = false;
            this.TBox_Inflation.Location = new System.Drawing.Point(356, 123);
            this.TBox_Inflation.Name = "TBox_Inflation";
            this.TBox_Inflation.Size = new System.Drawing.Size(159, 20);
            this.TBox_Inflation.TabIndex = 10;
            // 
            // TBox_TradeBalance
            // 
            this.TBox_TradeBalance.Enabled = false;
            this.TBox_TradeBalance.Location = new System.Drawing.Point(356, 150);
            this.TBox_TradeBalance.Name = "TBox_TradeBalance";
            this.TBox_TradeBalance.Size = new System.Drawing.Size(159, 20);
            this.TBox_TradeBalance.TabIndex = 11;
            // 
            // TBox_HDI
            // 
            this.TBox_HDI.Enabled = false;
            this.TBox_HDI.Location = new System.Drawing.Point(356, 177);
            this.TBox_HDI.Name = "TBox_HDI";
            this.TBox_HDI.Size = new System.Drawing.Size(159, 20);
            this.TBox_HDI.TabIndex = 12;
            // 
            // TBox_MainTradePartners
            // 
            this.TBox_MainTradePartners.Enabled = false;
            this.TBox_MainTradePartners.Location = new System.Drawing.Point(356, 204);
            this.TBox_MainTradePartners.Name = "TBox_MainTradePartners";
            this.TBox_MainTradePartners.Size = new System.Drawing.Size(159, 20);
            this.TBox_MainTradePartners.TabIndex = 13;
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(537, 94);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Edit.TabIndex = 14;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Location = new System.Drawing.Point(537, 175);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.Btn_Delete.TabIndex = 15;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(537, 148);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 16;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Location = new System.Drawing.Point(537, 121);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.Btn_Submit.TabIndex = 17;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            // 
            // Label_N_Countries
            // 
            this.Label_N_Countries.AutoSize = true;
            this.Label_N_Countries.Location = new System.Drawing.Point(234, 239);
            this.Label_N_Countries.Name = "Label_N_Countries";
            this.Label_N_Countries.Size = new System.Drawing.Size(0, 13);
            this.Label_N_Countries.TabIndex = 18;
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(275, 259);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(0, 13);
            this.Label_Height.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 283);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.Label_N_Countries);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.TBox_MainTradePartners);
            this.Controls.Add(this.TBox_HDI);
            this.Controls.Add(this.TBox_TradeBalance);
            this.Controls.Add(this.TBox_Inflation);
            this.Controls.Add(this.TBox_GDP);
            this.Controls.Add(this.TBox_Name);
            this.Controls.Add(this.Label_MainTradePartners);
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
        private System.Windows.Forms.Label Label_MainTradePartners;
        private System.Windows.Forms.TextBox TBox_Name;
        private System.Windows.Forms.TextBox TBox_GDP;
        private System.Windows.Forms.TextBox TBox_Inflation;
        private System.Windows.Forms.TextBox TBox_TradeBalance;
        private System.Windows.Forms.TextBox TBox_HDI;
        private System.Windows.Forms.TextBox TBox_MainTradePartners;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Label Label_N_Countries;
        private System.Windows.Forms.Label Label_Height;
    }
}