using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingData.Tests
{
    [TestFixture]
    public class Tests
    {
        private Country[] countries;

        private CountryAVLTree countryAVL;

        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        [OneTimeSetUp]
        public void Init()
        {
            countries = CountryParser.GetCountries(URL);
            countryAVL = new CountryAVLTree();
            countries.ToList().ForEach(country => countryAVL.Create(country));
        } 

        /// <summary>
        /// This test aims to establish if the <code>CountryParser</code> is capable of 
        /// constructing each of the countries within the supplied data file. It tests to see if it
        /// has detected the correct number of countries and that have been placed into the array 
        /// correctly.
        /// </summary>
        /// <see cref="CountryParser"/>
        [Test]
        public void ParserContents()
        {
            Assert.AreEqual(27, countries.Length);
        }

        /// <summary>
        /// This test aims to establish if the <code>CountryParser</code> is capable of 
        /// constructing each of the countries within the supplied data file. It tests to see if it
        /// can create each of the new countries with the correct data for each. It ensures that it
        /// is creating the country with it's own data and not others in addition to this it 
        /// ensures that agreeded upon variable types are being for the various pieces of data. 
        /// The expected data has been pulled by hand from the countries.csv file.
        /// </summary>
        /// <see cref="CountryParser"/>
        [Test]
        public void ParserFormat()
        {
            Country USA = countries[0];
            Assert.AreEqual("USA", USA.Name);
            Assert.AreEqual(1.8f, USA.GDP);
            Assert.AreEqual(2f, USA.Inflation);
            Assert.AreEqual(-3.1f, USA.TradeBalance);
            Assert.AreEqual(4f, USA.HDI);
            Assert.AreEqual(new LinkedList<String>(new String[] { "Canada", "UK", "Brazil" }), USA.TradePartners);
        }

        /// <summary>
        /// This test determines if the AVLTree containing all of the countries have succesfully
        /// been stored within the tree in addition to being located and returned for usage outside
        /// or updating later down the line.
        /// </summary>
        /// <see cref="CountryAVLTree"/>
        [Test]
        public void CountryAVLGet()
        {
            Country USAFromFile = countries[0];
            Country USAFromTree = countryAVL.Get("USA");
            Assert.AreEqual(USAFromFile.Name, USAFromTree.Name);
        }
    }
}
