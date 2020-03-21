using Algorithms.Data_Structure;
using DSA.Algorithms;
using DSA.Helpers;
using System;
using System.Diagnostics;

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
            Console.WriteLine();

            Console.WriteLine(bst.FindKey(80));

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

            #region ArrBstPerformanceComparison
            //Stopwatch watch = new Stopwatch();
            //Random random = new Random();
            //int findKey = 1187171871;
            //int size = 4000000;

            //// Array performance.
            //watch.Start();
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = random.Next(1, size * 10);
            //}
            //watch.Stop();
            //long arrAllocationTime = watch.ElapsedMilliseconds;

            //watch.Reset();
            //watch.Start();
            ////for (int i = 0; i < arr.Length; i++)
            ////{
            ////    Console.WriteLine(arr[i]);
            ////}
            //watch.Stop();
            //long arrTraversalTime = watch.ElapsedMilliseconds;

            //watch.Reset();
            //arr[arr.Length - 1] = findKey;
            //watch.Start();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (findKey == arr[i])
            //    {
            //        Console.WriteLine("\n\n\n\n-------------Found-----------\n\n\n\n");
            //        break;
            //    }
            //}
            //watch.Stop();
            //TimeSpan arrFindTime = watch.Elapsed;

            //// BST performance.
            //watch.Reset();
            //watch.Start();
            //BinarySearchTree bst = new BinarySearchTree();
            //for (int i = 0; i < size; i++)
            //{
            //    bst.Insert(random.Next(1, size * 10));
            //}
            //watch.Stop();
            //long bstAllocationTime = watch.ElapsedMilliseconds;


            //watch.Reset();
            //watch.Start();
            ////bst.InOrderTraversal();
            //watch.Stop();
            //long bstTraversalTime = watch.ElapsedMilliseconds;



            //watch.Reset();
            //bst.Insert(findKey);
            //watch.Start();
            //bst.FindKey(findKey);
            //watch.Stop();
            //TimeSpan bstFindTime = watch.Elapsed;

            //Console.WriteLine(); Console.WriteLine();
            //Console.WriteLine($"ARR ALLOCATION TIME : {arrAllocationTime}");
            //Console.WriteLine($"BST ALLOCATION TIME : {bstAllocationTime}");
            //Console.WriteLine();
            //Console.WriteLine($"ARR TRAVERSAL TIME : {arrTraversalTime}");
            //Console.WriteLine($"BST TRAVERSAL TIME : {bstTraversalTime}");
            //Console.WriteLine();
            //Console.WriteLine($"ARR FIND TIME : {arrFindTime}");
            //Console.WriteLine($"BST FIND TIME : {bstFindTime}");
            //Console.WriteLine();
            #endregion
        }
    }
}