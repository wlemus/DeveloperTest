using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;
using PruebaDataMart_net.BinaryTree;

namespace PruebaTest
{
    [TestFixture]
    internal class BinaryTreeTest
    {
        #region "InsertNode"
        /// <summary>
        /// When Tree IsEmpty Should Insert Root Node
        /// </summary>
        [Test]
        public void TestInsertNode_WhenTreeIsEmpty_ShouldInsertRootNode()
        {
            BinaryTree tree = new BinaryTree();
            int value = 5;

            tree.InsertNode(value);

            Assert.That(tree.root, Is.Not.Null);
            Assert.That(tree.root.value, Is.EqualTo(value));
        }
        /// <summary>
        /// When Tree IsNot Empty And Value Is NotPresent ShouldInsertNode
        /// </summary>
        [Test]
        public void TestInsertNode_WhenTreeIsNotEmptyAndValueIsNotPresent_ShouldInsertNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.InsertNode(5); // Insert root node
            tree.InsertNode(3); // Insert left child
            tree.InsertNode(8); // Insert right child
            int value = 6;

            tree.InsertNode(value);

            Assert.That(tree.ContainNode(value), Is.True);
        }
        /// <summary>
        /// When Value Is Already Present ShouldNotInsertNode
        /// </summary>
        [Test]
        public void TestInsertNode_WhenValueIsAlreadyPresent_ShouldNotInsertNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.InsertNode(5); // Insert root node
            tree.InsertNode(3); // Insert left child
            tree.InsertNode(8); // Insert right child
            int value = 3; // Value already exists

            Assert.Throws<InvalidOperationException>(() => tree.InsertNode(value));
        }
        #endregion
        #region "SearchNode"
        /// <summary>
        ///  When Tree Is Empty Should Return Null
        /// </summary>
        [Test]
        public void TestSearchNode_WhenTreeIsEmpty_ShouldReturnNull()
        {
            BinaryTree tree = new BinaryTree();
            int value = 5;

            Node? result = tree.SearchNode(value);

            Assert.That(result, Is.Null);
        }
        /// <summary>
        ///  When Value Exists In Tree Should Return Node
        /// </summary>
        [Test]
        public void TestSearchNode_WhenValueExistsInTree_ShouldReturnNode()
        {
            BinaryTree tree = new BinaryTree();
            tree.InsertNode(5); // Insert root node
            tree.InsertNode(3); // Insert left child
            tree.InsertNode(8); // Insert right child
            int value = 3; // Value to search

            Node? result = tree.SearchNode(value);

            Assert.That(result, Is.Not.Null);
            Assert.That(result.value, Is.EqualTo(value));
        }
        /// <summary>
        /// When Value Does Not Exist In Tree Should Return Null
        /// </summary>
        [Test]
        public void TestSearchNode_WhenValueDoesNotExistInTree_ShouldReturnNull()
        {
            BinaryTree tree = new BinaryTree();
            tree.InsertNode(5); // Insert root node
            tree.InsertNode(3); // Insert left child
            tree.InsertNode(8); // Insert right child
            int value = 10; // Value not present in tree

            Node? result = tree.SearchNode(value);

            Assert.That(result, Is.Null);
        }
        #endregion
    }

}

