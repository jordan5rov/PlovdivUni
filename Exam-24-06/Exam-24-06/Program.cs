namespace Exam_24_06;

class Program
{
    public static void MergeArrays(int[] arr1, int[] arr2, int arr1Len, int arr2Len, int[] arr3)
    {
        int i = 0, j = 0, k = 0;

        // Traverse both array
        while (i < arr1Len && j < arr2Len)
        {
            // Check if current element
            // of first array is smaller
            // than current element
            // of second array. If yes,
            // store first array element
            // and increment first array
            // index. Otherwise do same
            // with second array
            if (arr1[i] < arr2[j])
                arr3[k++] = arr1[i++];
            else
                arr3[k++] = arr2[j++];
        }

        // Store remaining
        // elements of first array
        while (i < arr1Len)
            arr3[k++] = arr1[i++];

        // Store remaining elements
        // of second array
        while (j < arr2Len)
            arr3[k++] = arr2[j++];
    }

    public static bool CheckPalindrome(string myString)
    {
        string first = myString.Substring(0, myString.Length / 2);
        char[] arr = myString.ToCharArray();

        Array.Reverse(arr);

        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);

        return first.Equals(second);
    }
    public static int LongestIncreaingSubsequence(int[] nums){
        int res = 0, count = 0;
        for (int i = 0; i < nums.Count(); i++){
            if (i == 0 || nums[i] > nums[i - 1]){
                count++;
                res = Math.Max(res, count);
            }
            else{
                count = 1;
            }
        }
        return res;
    }
    public static void Main()
    {
        int[] arr1 = {1, 3, 5, 7};
        int arr1Len = arr1.Length;

        int[] arr2 = {2, 4, 6, 8};
        int arr2Length = arr2.Length;

        int[] arr3 = new int[arr1Len + arr2Length];

        MergeArrays(arr1, arr2, arr1Len, arr2Length, arr3);

        Console.Write("Array after merging\n");
        for (int i = 0; i < arr1Len + arr2Length; i++)
            Console.Write(arr3[i] + " ");


        string palindrome = "aka";
        string notPalindrome = "kokosi";

        Console.WriteLine(CheckPalindrome(palindrome));
        Console.WriteLine(CheckPalindrome(notPalindrome));

        int[] numbers = new[] {0, 1, 1, 5, 2, 2, 6, 3, 3};

        // Some variables to keep track of the sequence we're currently looking
        // at, and the longest sequence we've found so far. We're going to start
        // the loop at the 2nd number, so we'll initialize these as if we've
        // already processed the first number (which is 0, so we've seen the
        // first number of a sequence of 0's).        

        // Number of numbers in the current sequence
        int count = 1;
        // Number which is part of the longest sequence so far
        int longestNum = numbers[0];
        // Number of numbers in the longest sequence we've seen so far
        int longestCount = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            // We're starting a new sequence
            if (numbers[i] != numbers[i - 1])
            {
                count = 0;
            }

            count++;
            // Have we just found a new longest sequence?
            if (count > longestCount)
            {
                longestCount = count;
                longestNum = numbers[i];
            }
        }

        // longestNum = 1 and longestCount = 2 (because the longest sequence
        // had 2 1's in it). Turn this into the string "1 1".
        Console.WriteLine(
            string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));

        // If you wanted to end up with an array containing [1, 1], then:
        int[] result = new int[longestCount];
        Array.Fill(result, longestNum);

        Console.WriteLine(LongestIncreaingSubsequence(numbers));
        
        static int f(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            if (x == 1)
            {
                return 1;
            }

            int n = x / 2;

            if (x % 2 == 0)
            {
                return f(n);
            }
            return f(n) + f(n + 1);
            
        }
        // g(x): g(0)=1, g(1)=0, g(2n)=g(n)+1, g(2n+1)=2g(n - 1)g(n)+g(n+1), n &gt; 0. За въведено x да се намери g(x).
        static int g(int x)
        {
            if (x == 0)
            {
                return 1;
            }

            if (x == 1)
            {
                return 0;
            }

            int n = x / 2;

            if (x % 2 == 0)
            {
                return g(n) + 1;
            }

            return 2 * g(n - 1) * g(n) + g(n + 1);

        }
    }
}