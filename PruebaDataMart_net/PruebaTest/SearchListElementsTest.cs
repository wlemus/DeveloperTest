using PruebaDataMart_net;
using PruebaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTest
{
    [TestFixture]
    internal class SearchListElementsTest
    {

        /// <summary>
        ///  When any List Is Null Should ThrowException
        /// </summary>
        [Test]
        public void TestFindListsElements_WhenAnyListIsNull_ShouldThrowException()
        {
            List<int> domainList = null;
            List<int> elementsList = null;
            int numElementsReqParallelism = 4;
            int maxNumWorkers = 3;
            SearchListsElements searchListsElements = new SearchListsElements(numElementsReqParallelism, maxNumWorkers);
            Assert.Throws<ArgumentNullException>(() => searchListsElements.FindListsElements(domainList, elementsList));
        }

        /// <summary>
        /// When Domain List Is Empty Should Return False
        /// </summary>
        [Test]
        public void TestFindListsElements_WhenDomainListIsEmpty_ShouldReturnFalse()
        {
            List<int> domainList = new List<int>();
            List<int> elementsList = new List<int> { 1, 2, 3 };
            int numElementsReqParallelism = 4;
            int maxNumWorkers = 3;
            SearchListsElements searchListsElements = new SearchListsElements(numElementsReqParallelism, maxNumWorkers);
            bool result = searchListsElements.FindListsElements(domainList, elementsList);

            Assert.That(result, Is.False);
        }
        /// <summary>
        /// When Elements List Is Empty Should Return False
        /// </summary>
        [Test]
        public void TestFindListsElements_WhenElementsListIsEmpty_ShouldReturnFalse()
        {
            List<int> domainList = new List<int> { 1, 2, 3 };
            List<int> elementsList = new List<int>();
            int numElementsReqParallelism = 4;
            int maxNumWorkers = 3;
            SearchListsElements searchListsElements = new SearchListsElements(numElementsReqParallelism, maxNumWorkers);

            bool result = searchListsElements.FindListsElements(domainList, elementsList);

            Assert.That(result, Is.False);
        }
        /// <summary>
        /// When DomainList And ElementsList Are Not Empty And No Common Elements Exist Should Return False
        /// </summary>
        [Test]
        public void TestFindListsElements_WhenDomainListAndElementsListAreNotEmptyAndNoCommonElementsExist_ShouldReturnFalse()
        {
            List<int> domainList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> elementsList = new List<int> { 6, 7, 8, 9 };
            int numElementsReqParallelism = 5;
            int maxNumWorkers = 3;
            SearchListsElements searchListsElements = new SearchListsElements(numElementsReqParallelism, maxNumWorkers);

            bool result = searchListsElements.FindListsElements(domainList, elementsList);

            Assert.That(result, Is.False);
        }
        /// <summary>
        /// When Domain List And ElementsList Are Not Empty And Common Elements Exist Should Return True
        /// </summary>
        [Test]
        public void TestFindListsElements_WhenDomainListAndElementsListAreNotEmptyAndCommonElementsExist_ShouldReturnTrue()
        {
            List<int> domainList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> elementsList = new List<int> { 3, 6, 7, 8 };
            int numElementsReqParallelism = 4;
            int maxNumWorkers = 3;
            SearchListsElements searchListsElements = new SearchListsElements(numElementsReqParallelism, maxNumWorkers);

            bool result = searchListsElements.FindListsElements(domainList, elementsList);

            Assert.IsTrue(result);
        }
    }

}
