using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDataMart_net.BinaryTree
{
    public class BinaryTree
    {
        public  Node? root { get; set; }
        public int length { get; set; }
        static readonly int COUNT = 5;

        #region "INSERT NODE"
        //**************************************INSERT NODE *********************************************
        public void InsertNode(int value )
        {
            if (root == null )
                root = new Node(value);
            else
            {
                if (ContainNode(value))
                    throw new InvalidOperationException();                
                else
                    InsertNodeRecursive(this.root, value);
            }
            length++;
        }

        private void InsertNodeRecursive(Node CurrentNode, int value)
        {
            if (value > CurrentNode.value)
            {
                if (CurrentNode.hasRightChild)
                    InsertNodeRecursive(CurrentNode.rightChild, value);
                else
                    CurrentNode.rightChild = new Node(value, CurrentNode, Utils.nodeOrientationType.Right, null, null);

            }
            else
            {
                if (CurrentNode.hasLeftChild)
                    InsertNodeRecursive(CurrentNode.leftChild, value);
                else
                    CurrentNode.leftChild = new Node(value, CurrentNode, Utils.nodeOrientationType.Left, null, null);
            }
        }

        public bool ContainNode(int value)
        {
            if ( SearchNodeRecursive(root,value) != null)
                return true;
            else
                return false;
        }

        #endregion
        #region "SEARCH NODE"
        //**************************************SEARCH NODE *********************************************
        public Node? SearchNode(int value)
        {
            Node fondNode = null;
            if (root != null)
            {
                fondNode = SearchNodeRecursive(root, value);
            }
         
         return fondNode;
        }



        private Node? SearchNodeRecursive(Node CurrentNode, int value)
        {
            if (CurrentNode != null)
            { 
                if (CurrentNode.value == value)
                    return CurrentNode;
                else if (CurrentNode.value < value)
                    return SearchNodeRecursive(CurrentNode.rightChild, value);
                else
                    return SearchNodeRecursive(CurrentNode.leftChild, value);
            }
            else
                return null;
        }
        #endregion


        #region "PRINT TREE"
        //**************************************PRINT TREE *********************************************

        public void PrintTree()
        {
            // Pass initial space count as 0
            PrintTreeRecursive(root, 0);
        }

         private void PrintTreeRecursive(Node root, int space)
        {
            if (root != null)
            {
                space += COUNT; //Increase distance between levels
                                
                PrintTreeRecursive(root.rightChild, space); //Process right child

                // Print current node after space
                Console.Write("\n");
                for (int i = COUNT; i < space; i++)
                    Console.Write(" ");

                Console.Write(root.value + "\n");

                PrintTreeRecursive(root.leftChild, space); //Process left child
            }           
        }
        #endregion

    }
}
