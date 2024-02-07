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
    internal class RemoveDuplicatesTest
    {
        //When List IsNull Should Throw Exception
        [Test]
        public void TestRemoveDuplicates_WhenListIsNull_ShouldThrowException()
        {
            List<int> elementsList = null;

            Assert.Throws<ArgumentNullException>(() => ListsUtils.remove_duplicates(elementsList));
        }
        /// <summary>
        /// When List Is Empty Should Return Empty List
        /// </summary>
        [Test]
        public void TestRemoveDuplicates_WhenListIsEmpty_ShouldReturnEmptyList()
        {
            List<int> elementsList = new List<int>();

            List<int>? result = ListsUtils.remove_duplicates(elementsList);

            Assert.That(result, Is.Not.Null);
            Assert.IsEmpty(result);
        }
        /// <summary>
        /// When List Has No Duplicates Should Return SameList
        /// </summary>
        [Test]
        public void TestRemoveDuplicates_WhenListHasNoDuplicates_ShouldReturnSameList()
        {
            List<int> elementsList = new List<int> { 1, 2, 3, 4, 5 };

            List<int>? result = ListsUtils.remove_duplicates(elementsList);

            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(elementsList.Count));
            CollectionAssert.AreEqual(elementsList, result);
        }
        /// <summary>
        /// When List Has Duplicates Should Return List Without Duplicates
        /// </summary>
        [Test]
        public void TestRemoveDuplicates_WhenListHasDuplicates_ShouldReturnListWithoutDuplicates()
        {
            // Arrange
            List<int> elementsList = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

            // Act
            List<int>? result = ListsUtils.remove_duplicates(elementsList);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Count, Is.EqualTo(5));
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, result);
        }
    }
}
