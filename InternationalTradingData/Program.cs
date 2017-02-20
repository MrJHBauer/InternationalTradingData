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
            AVLTree<String, Country> CountryAVLTree = new AVLTree<string, Country>();
            foreach(Country country in CountryParser.GetCountries("countries.csv"))
            {
                CountryAVLTree.Create(country.Name, country);
            }
            Console.WriteLine(String.Join("\n", CountryAVLTree.InOrder()));
            Console.ReadKey();           
        }
    }
}
