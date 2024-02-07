using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using PruebaDataMart_net;

namespace PruebaTest
{
    [TestFixture]
    internal class FindCommonElementsTest
    {
        /// <summary>
        ///When List Is Null Should Throw Exception
        /// </summary>
        [Test]
        public void TestFindCommonElements_WhenListIsNull_ShouldThrowException()
        {
            List<List<int>> elementsList = null;

            Assert.Throws<ArgumentNullException>(() => ListsUtils.findCommonElements(elementsList));
        }
        /// <summary>
        ///When List Is Empty Should Return Null
        /// </summary>
        [Test]
        public void TestFindCommonElements_WhenListIsEmpty_ShouldReturnNull()
        {
            List<List<int>> elementsList = new List<List<int>>();

            List<int>? result = ListsUtils.findCommonElements(elementsList);

            Assert.That(result, Is.Null);
        }
        /// <summary>
        ///When Lists Have No Common Elements Should Return Empty List
        /// </summary>
        [Test]
        public void TestFindCommonElements_WhenListsHaveNoCommonElements_ShouldReturnEmptyList()
        {
            List<List<int>> elementsList = new List<List<int>>
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

            List<int>? result = ListsUtils.findCommonElements(elementsList);

            Assert.That(result, Is.Not.Null);
            Assert.IsEmpty(result);
        }
        /// <summary>
        ///When Lists Have Common Elements Should Return Common Elements
        /// </summary>
        [Test]
        public void TestFindCommonElements_WhenListsHaveCommonElements_ShouldReturnCommonElements()
        {
            List<List<int>> elementsList = new List<List<int>>
        {
            new List<int> { 1, 2, 3, 4 },
            new List<int> { 3, 4, 5, 6 },
            new List<int> { 2, 3, 4, 5 }
        };

            List<int>? result = ListsUtils.findCommonElements(elementsList);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            CollectionAssert.AreEqual(new List<int> { 3, 4 }, result);
        }
   


}
}
