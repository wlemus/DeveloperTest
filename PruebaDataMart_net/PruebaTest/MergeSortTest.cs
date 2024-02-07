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
    internal class MergeSortTest
      {
        /// <summary>
        ///  When List Is Null Should ThrowException
        /// </summary>
        [Test]
        public void TestOrderByMergesort_WhenListIsNull_ShouldThrowException()
        {
            List<int> elementsList = null;

            Assert.Throws<ArgumentNullException>(() => ListsUtils.OrderByMergesort(elementsList));
        }
        /// <summary>
        /// When List Is Empty Should Return Empty List
        /// </summary>
        [Test]
        public void TestOrderByMergesort_WhenListIsEmpty_ShouldReturnEmptyList()
        {
            List<int> elementsList = new List<int>();

            List<int> result = ListsUtils.OrderByMergesort(elementsList);

            Assert.IsNotNull(result);
            Assert.That(result, Is.Empty);
        }
        /// <summary>
        /// When List Has One Element Should Return Same List
        /// </summary>
        [Test]
        public void TestOrderByMergesort_WhenListHasOneElement_ShouldReturnSameList()
        {
            List<int> elementsList = new List<int> { 5 };

            List<int> result = ListsUtils.OrderByMergesort(elementsList);

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0], Is.EqualTo(5));
        }
        /// <summary>
        /// When List Has Multiple Elements Should Return Ordered List
        /// </summary>
        [Test]
        public void TestOrderByMergesort_WhenListHasMultipleElements_ShouldReturnOrderedList()
        {
            List<int> elementsList = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            List<int> result = ListsUtils.OrderByMergesort(elementsList);

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(11));
            CollectionAssert.AreEqual(new List<int> { 1, 1, 2, 3, 3, 4, 5, 5, 5, 6, 9 }, result);
        }
    }

}

