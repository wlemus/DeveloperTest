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
    internal class BinarySearTest
    {
        /// <summary>
       ///When List Is Null Should Throw Exception
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenListIsNull_ShouldThrowException()
        {
            List<int> elementsList = null;
            int value = 5;

            Assert.Throws<ArgumentNullException>(() => ListsUtils.ExistsValueByBinarySearch(elementsList, value));
        }
        /// <summary>
       ///When List Is Empty Should Return False
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenListIsEmpty_ShouldReturnFalse()
        {
            List<int> elementsList = new List<int>();
            int value = 5;

            bool result = ListsUtils.ExistsValueByBinarySearch(elementsList, value);

            Assert.That(result, Is.False);
        }
        /// <summary>
       ///When Value Exists In List Should Return True
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenValueExistsInList_ShouldReturnTrue()
        {
            List<int> elementsList = new List<int> { 1, 2, 3, 4, 5 };
            int value = 3;

            bool result = ListsUtils.ExistsValueByBinarySearch(elementsList, value);

            Assert.That(result, Is.True);
        }
        /// <summary>
       ///When Value Does Not Exist In List Should Return False
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenValueDoesNotExistInList_ShouldReturnFalse()
        {
            List<int> elementsList = new List<int> { 1, 2, 4, 5 };
            int value = 3;

            bool result = ListsUtils.ExistsValueByBinarySearch(elementsList, value);

            Assert.That(result, Is.False);
        }
        /// <summary>
       ///When List Contains Only One Element And Value Matches Should Return True
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenListContainsOnlyOneElementAndValueMatches_ShouldReturnTrue()
        {
            List<int> elementsList = new List<int> { 5 };
            int value = 5;

            bool result = ListsUtils.ExistsValueByBinarySearch(elementsList, value);

            Assert.That(result, Is.True);
        }
        /// <summary>
       ///When List Contains Only One Element And Value Does Not Match Should Return False
        /// </summary>
        [Test]
        public void TestExistsValueByBinarySearch_WhenListContainsOnlyOneElementAndValueDoesNotMatch_ShouldReturnFalse()
        {
            List<int> elementsList = new List<int> { 5 };
            int value = 10;

            bool result = ListsUtils.ExistsValueByBinarySearch(elementsList, value);

            Assert.That(result, Is.False);
        }
    }


}
