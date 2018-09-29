﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] raw = new int[] { 8, 4, 9, 3, 11, 6, 2, 7, 12, 5, 10, 1 };
            int[] raw = FileOperations.GetTestData();

            Sort.Output(raw);
            Sort.Quick(raw, 0, raw.Length - 1).Output();
            //Sort.Merge(raw, 0, raw.Length - 1).Output();
            //Sort.Insertion(raw).Output();
            //Sort.Bubble(raw).Output();
            //Sort.Selection(raw).Output();

            //int index = Search.Linear(raw, 111);
            //int index = Search.Binary(raw, 8);
            //int index = Search.BinaryRecursive(raw, 0, raw.Length - 1, 12);
            //Console.WriteLine(index);
        }
    }

    static class Sort
    {
        #region COMPLETED
        /// <summary>
        /// Quick sort Algorith, using pivot as last element method;
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] Quick(int[] raw, int l, int r)
        {
            if (r > l)
            {
                int p = QuickConquer(raw, l, r);

                Quick(raw, l, p - 1);
                Quick(raw, p + 1, r);
            }
            return raw;
        }

        static int QuickConquer(int[] raw, int l, int r)
        {
            int pivot = raw[r];
            int i = l, j = l;
            //int n = r - l + 1;
            for (j = l; j < r; j++)
            {
                if (pivot > raw[j] && j != i)
                {
                    Swap(ref raw[i], ref raw[j]);
                    i++;
                }
                else if (pivot > raw[j])
                {
                    i++;
                }
            }

            raw[r] = raw[i];
            raw[i] = pivot;
            return i;
        }


        /// <summary>
        /// Merge sort Algorithm
        /// </summary>
        /// <param name="raw"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] Merge(int[] raw, int l, int r)
        {
            if (r > l)
            {
                int m = (l + r) / 2;
                Merge(raw, l, m);
                Merge(raw, m + 1, r);
                Combine(raw, l, m, r);
            }
            return raw;
        }

        static void Combine(int[] raw, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] la = new int[n1];
            int[] ra = new int[n2];
            int i, j;
            for (i = 0; i < la.Length; i++)
            {
                la[i] = raw[l + i];
            }
            for (j = 0; j < ra.Length; j++)
            {
                ra[j] = raw[m + 1 + j];
            }

            i = 0;
            j = 0;
            int k = l;
            while (i < la.Length && j < ra.Length)
            {
                if (la[i] > ra[j])
                {
                    raw[k] = ra[j];
                    j++;
                }
                else
                {
                    raw[k] = la[i];
                    i++;
                }
                k++;
            }

            while (i < la.Length)
            {
                raw[k] = la[i];
                i++;
                k++;
            }

            while (j < ra.Length)
            {
                raw[k] = ra[j];
                j++;
                k++;
            }
        }

        /// <summary>
        /// Insertion Sort Algorithm
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public static int[] Insertion(int[] raw)
        {
            for (int i = 1; i < raw.Length; i++)
            {
                int key = raw[i];
                int j;
                for (j = i; j >= 1 && key < raw[j - 1]; j--)
                {
                    raw[j] = raw[j - 1];
                }
                raw[j] = key;
            }
            return raw;
        }

        /// <summary>
        /// Selection Sort Algorithm;
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public static int[] Selection(int[] raw)
        {
            for (int i = 0; i < raw.Length; i++)
            {
                int smallestIndex = i;
                for (int j = i; j < raw.Length - 1; j++)
                {
                    if (raw[smallestIndex] > raw[j + 1])
                    {
                        smallestIndex = j + 1;
                    }
                }

                if (i != smallestIndex)
                {
                    Swap(ref raw[i], ref raw[smallestIndex]);
                }
            }

            return raw;
        }

        /// <summary>
        /// Bubble Sort Algorithm
        /// </summary>
        /// <param name="raw"></param>
        /// <returns></returns>
        public static int[] Bubble(int[] raw)
        {
            for (int i = 0; i < raw.Length; i++)
            {
                for (int j = 0; j < raw.Length - i - 1; j++)
                {
                    if (raw[j] > raw[j + 1])
                    {
                        Swap(ref raw[j], ref raw[j + 1]);
                    }
                }
            }
            return raw;
        }

        /// <summary>
        /// Swap Without Third Variable
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        /// <summary>
        /// Chainable Action Method
        /// </summary>
        /// <param name="arr"></param>
        public static void Output(this int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        #endregion
    }

    static class Search
    {
        #region COMPLETED
        /// <summary>
        /// Perform Search based on array sorted state;
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <param name="isSortedArray"></param>
        /// <returns></returns>
        public static int PerformSearch(int[] arr, int element, bool isSortedArray)
        {
            if (isSortedArray)
            {
                return Binary(arr, element);
            }
            else
            {
                return Linear(arr, element);
            }
        }

        /// <summary>
        /// Perform Linear Search
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int Linear(int[] arr, int element)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        /// <summary>
        /// Perform Binary search on a sorted array;
        /// </summary>
        /// <param name="sortedArray"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int Binary(int[] sortedArray, int element)
        {
            int index = -1,
                start = 0,
                end = sortedArray.Length - 1,
                middle = (end + start) / 2;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (element == sortedArray[middle])
                {
                    index = middle;
                    break;
                }
                else if (element >= sortedArray[middle])
                {
                    start = middle + 1;
                    middle = (end + start) / 2;
                    continue;
                }
                else
                {
                    end = middle - 1;
                    middle = (end + start) / 2;
                    continue;
                }
            }

            return index;
        }

        /// <summary>
        /// Recursive Binary search
        /// </summary>
        /// <param name="sortedArray"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int BinaryRecursive(int[] sortedArray, int start, int end, int element)
        {
            if (end >= start)
            {
                int middle = (start + end) / 2;
                if (sortedArray[middle] == element)
                {
                    return middle;
                }
                else if (sortedArray[middle] > element)
                {
                    return BinaryRecursive(sortedArray, start, middle - 1, element);
                }
                else
                {
                    return BinaryRecursive(sortedArray, middle + 1, end, element);
                }
            }
            return -1;
        }
        #endregion
    }

    public static class FileOperations
    {
        public static int[] GetTestData()
        {
            return ReadTestFiles();
        }

        static int[] ReadTestFiles()
        {
            try
            {
                var testCaseFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "\\testcases");
                var testCaseFiles = Directory.GetFiles(testCaseFolderPath);

                var lines = File.ReadAllLines(testCaseFiles[0]);
                int[] arr = new int[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    arr[i] = Convert.ToInt32(lines[i]);
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}