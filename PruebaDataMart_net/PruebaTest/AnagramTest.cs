using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PruebaDataMart_net;

namespace PruebaTest
{
    [TestFixture]
    internal class AnagramTest
    {
        /// <summary>
        /// When Strings Are Anagrams Should Return True
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenStringsAreAnagrams_ShouldReturnTrue()
        {
            string string1 = "listen";
            string string2 = "silent";

            bool result = Anagram.isAnagram(string1, string2);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// When Strings Have Acents Are Anagrams Should ReturnTrue
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenStringsHaveAcentsAreAnagrams_ShouldReturnTrue()
        {
            string string1 = "Lácteo";
            string string2 = "coleta";

            bool result = Anagram.isAnagram(string1, string2);

            Assert.IsTrue(result);
        }
        /// <summary>
        /// When Strings Are Not Anagrams Should Return False
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenStringsAreNotAnagrams_ShouldReturnFalse()
        {
            string string1 = "hello";
            string string2 = "world";

            bool result = Anagram.isAnagram(string1, string2);

            Assert.That(result, Is.False);
        }
        /// <summary>
        /// When Strings Have Different Lengths Should Return False
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenStringsHaveDifferentLengths_ShouldReturnFalse()
        {
            string string1 = "listen";
            string string2 = "silentt";

            bool result = Anagram.isAnagram(string1, string2);

            Assert.That(result, Is.False);
        }

        /// <summary>
        /// When Strings Contain Different Characters Should Return False
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenStringsContainDifferentCharacters_ShouldReturnFalse()
        {
            string string1 = "listen";
            string string2 = "sylvan";


            bool result = Anagram.isAnagram(string1, string2);

            Assert.That(result, Is.False);
        }

        /// <summary>
        /// When One String Is Null Should Throw Exception
        /// </summary>
        [Test]
        public void TestIsAnagram_WhenOneStringIsNull_ShouldThrowException()
        {
            string string1 = "listen";
            string string2 = null;

            Assert.Throws<ArgumentNullException>(() => Anagram.isAnagram(string1, string2));
        }
    }
}
