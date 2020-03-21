using Algorithms.Data_Structure;
using DSA.Algorithms;
using DSA.Helpers;
using System;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {

            #region DS

            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(70);
            bst.Insert(60);
            bst.Insert(80);

            bst.InOrderTraversal();
            Console.WriteLine();

            bst.PreOrderTraversal();
            Console.WriteLine();

            bst.PostOrderTraversal();

            #endregion

            #region Algorithms
            //int[] raw = new int[] { 8, 4, 9, 3, 11, 6, 2, 7, 12, 5, 10, 1 };
            //int[] raw = FileOperations.GetTestData();

            // Sorting.Output(raw);
            //Sorting.Quick(raw, 0, raw.Length - 1).Output();
            // Sorting.Merge(raw, 0, raw.Length - 1).Output();
            // Sorting.Insertion(raw).Output();
            // Sorting.Bubble(raw).Output();
            // Sorting.Selection(raw).Output();

            // int index = Searching.Linear(raw, 111);
            // int index = Searching.Binary(raw, 8);
            // int index = Searching.BinaryRecursive(raw, 0, raw.Length - 1, 12);
            // Console.WriteLine(index); 
            #endregion
        }
    }
}