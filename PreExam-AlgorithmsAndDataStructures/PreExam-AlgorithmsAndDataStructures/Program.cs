using System;
using System.Linq;

namespace PreExam_AlgorithmsAndDataStructures
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var sortedNumbers = new[] {0, 1, 21, 33, 45, 45, 61, 71, 72, 73};
            Console.WriteLine(Algorithms.BinarySearch(sortedNumbers, 5));

            /*
             Read array in single line split by space
             Example: 1 5 6 7 8
            */
            
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Algorithms.SelectionSort(numbers);
            Console.WriteLine(string.Join(" ", numbers) );
        }
    }
}