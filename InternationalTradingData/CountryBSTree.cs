using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    public class CountryBSTree : BSTree<String, Country>
    {
        public CountryBSTree() : base() { }

        public CountryBSTree(Country Country) : base(Country.Name, Country) { }

        public void Create(Country Country)
        {
            base.Create(Country.Name, Country);
        }
        
        public void Edit(Country Country)
        {
            base.Edit(Country.Name, Country);
        }

        public List<String> GetTradeWith(String Name)
        {
            List<String> partners = new List<string>();
            List<String> countries = InOrder();
            foreach(String countryName in countries)
            {
                if(Get(countryName).TradePartners.Contains(Name))
                {
                    partners.Add(countryName);
                }
            }
            return partners;
        }
    }
}
