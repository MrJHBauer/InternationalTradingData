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

        private Country Argentina, UK, USA, Canada, Brazil;

        private BinaryTree<String, Country> binaryTreeCountry;

        private String URL = TestContext.CurrentContext.TestDirectory + "/countries.csv";

        [OneTimeSetUp]
        public void Init()
        {
            countries = CountryParser.GetCountries(URL);
            USA = countries[0];
            Canada = countries[1];
            Brazil = countries[2];
            UK = countries[8];
            Argentina = countries[26];

            binaryTreeCountry = new BinaryTree<string, Country>(UK.Name, UK);
            binaryTreeCountry.Root.Left = new Node<string, Country>(Brazil.Name, Brazil);
            binaryTreeCountry.Root.Left.Left = new Node<string, Country>(Argentina.Name, Argentina);
            binaryTreeCountry.Root.Left.Right = new Node<string, Country>(Canada.Name, Canada);
            binaryTreeCountry.Root.Right = new Node<string, Country>(USA.Name, USA);
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

        /// <summary>
        /// Test to see if the binary tree is capable of determing the correct height.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void TreeHeight()
        {
            Assert.AreEqual(2, binaryTreeCountry.GetHeight());
        }

        /// <summary>
        /// Test to see if the binary tree is capable of calculating the correct node population.
        /// </summary>
        /// <see cref="BinaryTree{TKey, TValue}"/>
        [Test]
        public void TreeNodeCount()
        {
            Assert.AreEqual(5, binaryTreeCountry.GetNodeCount());
        }

        /// <summary>
        /// Test to see if the binary tree is capable of reporting on if it contains a given node.
        /// </summary>
        [Test]
        public void TreeContains()
        {
            Assert.IsTrue(binaryTreeCountry.Contains("Canada"));
            Assert.IsFalse(binaryTreeCountry.Contains("France"));
        }

        /// <summary>
        /// Test to see if the binary tree is capable of fetching a specified node.
        /// </summary>
        [Test]
        public void TreeGet()
        {
            Assert.AreEqual(USA.GDP, binaryTreeCountry.Get("USA").GDP);
        }

        /// <summary>
        /// Test to see if the binary tree's traveral functions visit nodes correctly.
        /// </summary>
        [Test]
        public void TreeTraversal()
        {
            String[] inOrder = new String[] { "Argentina", "Brazil", "Canada", "UK", "USA" };
            String[] preOrder = new String[] { "UK", "Brazil", "Argentina", "Canada", "USA" };
            String[] postOrder = new String[] { "Argentina", "Canada", "Brazil", "USA", "UK" };
            Assert.AreEqual(new List<String>(inOrder), binaryTreeCountry.InOrder());
            Assert.AreEqual(new List<String>(preOrder), binaryTreeCountry.PreOrder());
            Assert.AreEqual(new List<String>(postOrder), binaryTreeCountry.PostOrder());
        }        
    }
}
