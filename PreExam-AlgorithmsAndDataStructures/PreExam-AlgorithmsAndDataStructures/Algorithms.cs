using System;

namespace PreExam_AlgorithmsAndDataStructures
{
    public class Algorithms
    {
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

        public static void Swap(int[] arr, int first, int second)
        {
            var temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            
        }
    }
}