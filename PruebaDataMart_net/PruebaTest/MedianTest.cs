using NUnit.Framework;
using PruebaDataMart_net;

namespace PruebaTest
{
    [TestFixture]
    public class MedianTests
    {

        /// <summary>
        /// When Array IsNull Should ThrowException
        /// </summary>
        [Test]
        public void TestFindMedian_WhenArrayIsNull_ShouldThrowException()
        {
            int[] array = null;

            Assert.Throws<Exception>(() => Median.find_median(array));
        }
        /// <summary>
        /// When Array Is Empty Should ThrowException
        /// </summary>
        [Test]
        public void TestFindMedian_WhenArrayIsEmpty_ShouldThrowException()
        {
            int[] array = new int[0];

            Assert.Throws<Exception>(() => Median.find_median(array));
        }
        /// <summary>
        /// When Array Has Pair Elements Array Should Return Median
        /// </summary>
        [Test]
        public void TestFindMedian_WhenArrayHasPairElementsArray_ShouldReturnMedian()
        {
            int[] array = { 10, -6, 50, 2, 8, -30, 5, 100, -9, 522, 68, 254, 2, 0, 45, 3, 9, 10 };

            decimal result = Median.find_median(array);

            Assert.That(result, Is.EqualTo(8.5));
        }
        /// <summary>
        /// When Array Has Un Pair Elements Array Should Return Median
        /// </summary>
        [Test]
        public void TestFindMedian_WhenArrayHasUnPairElementsArray_ShouldReturnMedian()
        {
            int[] array = { 10, 35, 40, 9, -5, 0, 20 };

            decimal result = Median.find_median(array);

            Assert.That(result, Is.EqualTo(10));
        }
    }
}