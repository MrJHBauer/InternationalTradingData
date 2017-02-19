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
            BinaryTree<String, Country> CountriesTree;
            Country[] countries = CountryParser.GetCountries("countries.csv");
            CountriesTree = new BinaryTree<string, Country>(countries[8].Name, countries[8]); // UK
            CountriesTree.Root.Left = new Node<string, Country>(countries[2].Name, countries[2]); // Brazil
            CountriesTree.Root.Left.Left = new Node<string, Country>(countries[26].Name, countries[26]); // Argentina
            CountriesTree.Root.Left.Right = new Node<string, Country>(countries[1].Name, countries[1]); // Canada
            CountriesTree.Root.Right = new Node<string, Country>(countries[0].Name, countries[0]); // USA
            Console.WriteLine($"Node Population: {CountriesTree.GetNodeCount()}, Tree Height: {CountriesTree.GetHeight()}");
            Console.WriteLine($"InOrder: {String.Join(", ", CountriesTree.InOrder())}");
            Console.WriteLine($"PreOrder: {String.Join(", ", CountriesTree.PreOrder())}");
            Console.WriteLine($"PostOrder: {String.Join(", ", CountriesTree.PostOrder())}");
            Console.WriteLine($"Get Argentina: {CountriesTree.Get("Argentina")}");
            Console.WriteLine($"Tree Contains USA: {CountriesTree.Contains("USA")}, Tree Contains Iceland: {CountriesTree.Contains("Iceland")}");
            Console.ReadKey();
        }
    }
}
