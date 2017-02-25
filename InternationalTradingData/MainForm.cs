using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternationalTradingData
{
    public partial class MainForm : Form
    {

        private CountryAVLTree countries = new CountryAVLTree();

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            foreach(Country country in CountryParser.GetCountries("countries.csv"))
            {
                countries.Create(country);
            }
            LBox_Countries.DataSource = countries.InOrder();
        }

        private void populateFields(Country country)
        {
            TBox_Name.Text = country.Name;
            TBox_GDP.Text = country.GDP.ToString();
            TBox_Inflation.Text = country.Inflation.ToString();
            TBox_TradeBalance.Text = country.TradeBalance.ToString();
            TBox_HDI.Text = country.HDI.ToString();
            TBox_MainTradePartners.Text = String.Join(", ", country.TradePartners);
        }

        private void enableFields(Boolean state)
        {
            TBox_Name.Enabled = state;
            TBox_GDP.Enabled = state;
            TBox_Inflation.Enabled = state;
            TBox_TradeBalance.Enabled = state;
            TBox_HDI.Enabled = state;
            TBox_MainTradePartners.Enabled = state;
        }

        private void LBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = countries.Get(LBox_Countries.SelectedItem.ToString());
            populateFields(selectedCountry);
            Label_N_Countries.Text = $"Number of countries: {countries.GetNodeCount()}";
            Label_Height.Text = $"Tree height: {countries.GetHeight()}";
            enableFields(false);
        }
        
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            countries.Delete(TBox_Name.Text);
            LBox_Countries.DataSource = countries.InOrder();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            TBox_Name.Text = "";
            TBox_GDP.Text = "";
            TBox_Inflation.Text = "";
            TBox_TradeBalance.Text = "";
            TBox_HDI.Text = "";
            TBox_MainTradePartners.Text = "";
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            enableFields(true);
        }
        
        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Country editedCountry = new Country();
            editedCountry.Name = TBox_Name.Text;
            editedCountry.GDP = float.Parse(TBox_GDP.Text);
            editedCountry.Inflation = float.Parse(TBox_Inflation.Text);
            editedCountry.TradeBalance = float.Parse(TBox_TradeBalance.Text);
            editedCountry.HDI = float.Parse(TBox_HDI.Text);
            editedCountry.TradePartners = new LinkedList<String>(TBox_MainTradePartners.Text.Split(','));
            countries.Edit(editedCountry);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void MItem_SearchName_Click(object sender, EventArgs e)
        {
            SearchCountryForm form = new SearchCountryForm(countries);
            form.Show();
        }
    }
}
