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
            Country UK = new Country("UK", 1, 2, 3, 4, 
                new LinkedList<string>(new String[] { "USA", "France", "Germany" }));
            Country USA = new Country("USA", 1, 2, 3, 4,
                new LinkedList<string>(new String[] { "Canada", "Mexico", "China" }));
            Console.WriteLine(UK);
            Console.WriteLine(USA);
            Console.WriteLine($"Is UK lexically smaller than USA: {UK.CompareTo(USA) == -1}");
            Console.ReadKey();
        }
    }
}
