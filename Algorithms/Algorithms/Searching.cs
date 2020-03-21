namespace DSA.Algorithms
{
    public static class Searching
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
}
