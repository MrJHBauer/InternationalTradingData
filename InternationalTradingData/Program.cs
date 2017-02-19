using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryBSTree CountryBSTree = new CountryBSTree();
            Country[] countries = CountryParser.GetCountries("countries.csv");
            foreach(Country country in countries)
            {
                CountryBSTree.Create(country);
            }
            Console.WriteLine($"All that trade with the UK\n{String.Join("\n", CountryBSTree.GetTradeWith("UK"))}");
            Console.ReadKey();           
        }
    }
}
