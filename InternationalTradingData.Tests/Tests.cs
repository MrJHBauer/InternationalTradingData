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
        public Country[] countries;

        private Country Argentina, UK, USA;

        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        [OneTimeSetUp]
        public void Init()
        {
            countries = CountryParser.GetCountries(URL);
            USA = countries[0];
            UK = countries[8];
            Argentina = countries[26];
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
            Assert.AreEqual("USA", USA.Name);
            Assert.AreEqual("UK", UK.Name);
            Assert.AreEqual("Argentina", Argentina.Name);
        }

        /// <summary>
        /// Test to see if <code>Country</code> has correctly implemented <code>IComparable</code> 
        /// interface and is making the correct comparisons between the different countries.
        /// </summary>
        /// <see cref="IComparable{T}"/>
        /// <seealso cref="Country"/>
        [Test]
        public void CountryComparison()
        {
            Assert.AreEqual(-1, UK.CompareTo(USA));
            Assert.AreEqual(1, UK.CompareTo(Argentina));
            Assert.AreEqual(0, UK.CompareTo(UK));
        }
    }
}
