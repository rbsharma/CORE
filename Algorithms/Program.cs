using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] raw = new int[] { 8, 4, 9, 3, 11, 6, 2, 7, 12, 5, 10, 1 };

            //Sort.Output(raw);
            Sort.Bubble(raw).Output();
            //Sort.Selection(raw).Output();

            //int index = Search.Linear(raw, 111);
            //Console.WriteLine(index);

            //int index = Search.Binary(raw, 8);
            //Console.WriteLine(index);

            int index = Search.BinaryRecursive(raw, 0, raw.Length - 1, 12);
            Console.WriteLine(index);
        }
    }

    static class Sort
    {

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
    }

    static class Search
    {
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
    }
}
