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

        private void LBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country selectedCountry = countries.Get(LBox_Countries.SelectedItem.ToString());
            populateFields(selectedCountry);
            Label_N_Countries.Text = $"Number of countries: {countries.GetNodeCount()}";
            Label_Height.Text = $"Tree height: {countries.GetHeight()}";
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            countries.Delete(TBox_Name.Text);
            LBox_Countries.DataSource = countries.InOrder();
        }
    }
}
