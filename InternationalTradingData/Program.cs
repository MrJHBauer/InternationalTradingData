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
            foreach(Country country in CountryParser.GetCountries("countries.csv"))
            {
                CountryBSTree.Create(country);
            }
            Console.WriteLine($"Partial Matching 'Ch'\n{String.Join("\n", CountryBSTree.GetPartials("C"))}");
            Console.ReadKey();           
        }
    }
}
