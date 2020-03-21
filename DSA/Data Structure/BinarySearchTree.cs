using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Data_Structure
{
    /// <summary>
    /// Binary Tree Node
    /// </summary>
    public class BinaryTreeNode
    {
        public BinaryTreeNode(int _value)
        {
            value = _value;
            Left = null;
            Right = null;
        }
        public int value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;
    }

    public class BinarySearchTree
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        /// <summary>
        /// Root Node of Binary Search Tree.
        /// </summary>
        BinaryTreeNode Root;

        /// <summary>
        /// Insert a new element in binary search tree.
        /// </summary>
        /// <param name="value"></param>
        public void Insert(int value)
        {
            Root = AddNode(Root, value);
        }

        BinaryTreeNode AddNode(BinaryTreeNode root, int _value)
        {
            // If tree is empty, return a new node.
            if (root == null)
            {
                root = new BinaryTreeNode(_value);
                return root;
            }

            // Otherwise, recur down the tree.
            if (_value < root.value)
            {
                root.Left = AddNode(root.Left, _value);
            }
            else
            {
                root.Right = AddNode(root.Right, _value);
            }

            // return the unchanged root node.
            return root;
        }

    }
}
