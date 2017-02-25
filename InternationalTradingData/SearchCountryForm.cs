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
    public partial class SearchCountryForm : Form
    {
        private CountryAVLTree countries;
        DataTable dataTable;
        public SearchCountryForm(CountryAVLTree countries)
        {
            InitializeComponent();
            this.countries = countries;
            init();
        }

        private void init()
        {
            initDataGrid();
        }

        private void initDataGrid()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(String));
            dataTable.Columns.Add("GDP", typeof(float));
            dataTable.Columns.Add("Inflation", typeof(float));
            dataTable.Columns.Add("Trade Balance", typeof(float));
            dataTable.Columns.Add("HDI", typeof(float));
            dataTable.Columns.Add("Trade Partners", typeof(String));

            DGridView_Countries.DataSource = dataTable;
        }

        private void TBox_Search_TextChanged(object sender, EventArgs e)
        {
            DGridView_Countries.DataSource = null;
            dataTable.Rows.Clear();
            String partial = TBox_Search.Text;
            foreach(String name in countries.GetPartials(partial))
            {
                Country country = countries.Get(name);
                dataTable.Rows.Add(new Object[] { country.Name, country.GDP,
                    country.Inflation, country.TradeBalance, country.HDI,
                    String.Join(", ", country.TradePartners) });
            }
            DGridView_Countries.DataSource = dataTable;
        }
    }
}
