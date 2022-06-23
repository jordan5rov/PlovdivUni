using System;
using System.Collections.Generic;

namespace PreExam_AlgorithmsAndDataStructures
{
    public class Algorithms
    {
        public static void Swap(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }

        // n ^ 2
        public static string BinarySearch(int[] arr, int number)
        {
            var startIdx = 0;
            var endIdx = arr.Length - 1;
            while (startIdx <= endIdx)
            {
                var midIdx = (startIdx + endIdx) / 2;
                if (arr[midIdx] == number)
                {
                    return $"The number {number} has been found at index {midIdx}";
                }

                if (number > arr[midIdx])
                {
                    startIdx = midIdx + 1;
                }
                else
                {
                    endIdx = midIdx - 1;
                }
            }

            return $"The number {number} has not been found in the array";
        }

        // n ^ 2
        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minIdx = i;
                var minNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < minNum)
                    {
                        minNum = arr[j];
                        minIdx = j;
                    }
                }

                Swap(arr, i, minIdx);
            }
        }

        // n ^ 2
        public static void BubbleSort(int[] arr)
        {
            var isSorted = false;
            var sortedElementsCount = 0;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 1; i < arr.Length - sortedElementsCount; i++)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        Swap(arr, i - 1, i);
                        isSorted = false;
                    }
                }
            }
        }

        // n ^ 2
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    Swap(arr, j, j - 1);
                    j -= 1;
                }
            }
        }
        
    }
}