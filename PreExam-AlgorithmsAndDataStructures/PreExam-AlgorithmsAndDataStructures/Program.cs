using System;
using System.Collections.Generic;
using System.Linq;

namespace PreExam_AlgorithmsAndDataStructures
{
    internal class Program
    {
        private static Dictionary<int, List<int>> graph;
        private static HashSet<int> visited;
        public static void Main(string[] args)
        {
            var sortedNumbers = new[] {0, 1, 21, 33, 45, 45, 61, 71, 72, 73};
            Console.WriteLine(Algorithms.BinarySearch(sortedNumbers, 5));

            /*
             Read array in single line split by space
             Example: 1 5 6 7 8
            */
            /*
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Algorithms.InsertionSort(numbers);
            Console.WriteLine(string.Join(" ", numbers) );

            graph = new Dictionary<int, List<int>>
            {
                {1, new List<int>{19, 21, 14}},
                {19, new List<int>{7, 12, 31, 21}},
                {7, new List<int>{1}},
                {12, new List<int>()},
                {21, new List<int>{14}},
                {31, new List<int>{21}},
                {14, new List<int>{23, 6}},
                {23, new List<int>{21}},
                {6, new List<int>()}
                
            };

            visited = new HashSet<int>();

            foreach (var node in graph.Keys)
            {
                DepthFirstSearch(node);
            }
            foreach (var node in graph.Keys)
            {
                if (!visited.Contains(node))
                {
                    BreadthFirstSearch(node);
                }
            }
            */

            List<int> increasingNums = new List<int>(); 
            int[] nums = {2, 4, 6, 2, 7, 12, 30, 9};


            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i;
                List<int> currentIncreasingNums = new List<int>();
                currentIncreasingNums.Add(nums[i]);
                while (nums[j] < nums[j + 1])
                {
                    currentIncreasingNums.Add(nums[j + 1]);
                    j++;
                }

                if (currentIncreasingNums.Count > increasingNums.Count)
                {
                    increasingNums = currentIncreasingNums;
                }
            }
            
        }

        private static void DepthFirstSearch(int node)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);

            foreach (var child in graph[node])
            {
                DepthFirstSearch(child);
            }

            Console.WriteLine(node);
        }
        
        private static void BreadthFirstSearch(int startNode)
        {
            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            visited.Add(startNode);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node);

                foreach (var child in graph[node])
                {
                    if (!visited.Contains(child))
                    {
                        queue.Enqueue(child);
                        visited.Add(child);
                    }
                        
                }
            }
        }
    }
}