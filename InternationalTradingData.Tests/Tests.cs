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
        private Country[] Countries;

        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        [OneTimeSetUp]
        public void Init()
        {
            Countries = CountryParser.GetCountries(URL);
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
            Assert.AreEqual(27, Countries.Length);
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
            Country USA = Countries[0];
            Assert.AreEqual("USA", USA.Name);
            Assert.AreEqual(1.8f, USA.GDP);
            Assert.AreEqual(2f, USA.Inflation);
            Assert.AreEqual(-3.1f, USA.TradeBalance);
            Assert.AreEqual(4f, USA.HDI);
            Assert.AreEqual(new LinkedList<String>(new String[] { "Canada", "UK", "Brazil" }), USA.TradePartners);
        }
    }
}
