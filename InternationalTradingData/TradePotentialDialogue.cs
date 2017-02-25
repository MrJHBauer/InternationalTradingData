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
    public partial class TradePotentialDialogue : Form
    {
        private CountryAVLTree countries;

        public TradePotentialDialogue(CountryAVLTree countries)
        {
            InitializeComponent();
            this.countries = countries;
            init();
        }

        private void init()
        {
            String name = countries.GetBiggestTradePotential();
            Country country = countries.Get(name);

            Label_TradePotential.Text = $"{country.Name} has the biggest trade potential";

        }
    }
}
