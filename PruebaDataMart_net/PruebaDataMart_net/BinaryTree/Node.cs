using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PruebaDataMart_net.Utils;

namespace PruebaDataMart_net.BinaryTree
{
    public class Node
    {
       
        public Utils.nodeOrientationType? leftRight { get; set;}
        public int value { get; set; }
        public Node? ParentNode { get; set; }
        public bool isRoot { get { return ParentNode == null; } }
        public Node? leftChild { get; set; }
        public bool hasLeftChild { get { return leftChild != null; } }
        public Node? rightChild { get; set; }
        public bool hasRightChild { get { return rightChild != null; } }
        //public nodeStateType nodeState { get; set; }
        //public int Depth { get; set; }

        public Node(int _value, Node? _ParentNode = null, Utils.nodeOrientationType? _leftRight = null, Node? _leftChild= null, Node? _rightChild = null)
        {
            value = _value;
            ParentNode = _ParentNode;
            leftChild = _leftChild;
            rightChild = _rightChild;
            leftRight = _leftRight;
        }
    }
}
