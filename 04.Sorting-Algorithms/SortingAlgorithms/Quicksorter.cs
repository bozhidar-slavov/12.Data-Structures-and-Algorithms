﻿namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private static void QuickSort(IList<T> arr, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high);
                QuickSort(arr, low, p - 1);
                QuickSort(arr, p + 1, high);
            }
        }

        private static int Partition(IList<T> arr, int low, int high)
        {
            int pivotIndex = (low + high) / 2;
            T pivotValue = arr[pivotIndex];
            arr[pivotIndex] = arr[high];
            arr[high] = pivotValue;

            int storeIndex = low;
            T temp;
            for (int i = low; i <= high - 1; i++)
            {
                if (arr[i].CompareTo(pivotValue) <= 0)
                {
                    temp = arr[i];
                    arr[i] = arr[storeIndex];
                    arr[storeIndex] = temp;
                    storeIndex++;
                }
            }

            temp = arr[storeIndex];
            arr[storeIndex] = arr[high];
            arr[high] = temp;

            return storeIndex;
        }
    }
}
