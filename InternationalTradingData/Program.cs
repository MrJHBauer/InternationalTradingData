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
            BSTree<String, Country> CountriesTree;
            Country[] countries = CountryParser.GetCountries("countries.csv");
            CountriesTree = new BSTree<string, Country>(countries[8].Name, countries[8]); // UK
            CountriesTree.Create(countries[1].Name, countries[1]); // Canada
            CountriesTree.Create(countries[2].Name, countries[2]); // Brazil
            CountriesTree.Create(countries[26].Name, countries[26]); // Argentina
            CountriesTree.Create(countries[0].Name, countries[0]); // USA
            Console.ReadKey();           
        }
    }
}
