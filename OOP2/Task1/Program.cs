// See https://aka.ms/new-console-template for more information
/*
 * Write a program that reads two arrays from the console and compares them element by element and by their lenght.
 */

int[] ReadArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write("Enter element {0}: ", i);
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.Write("Enter the lenght of the arrays: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the numbers for the first array");
int[] nums1 = ReadArray(n);
Console.WriteLine("Enter the numbers for the second array");
int[] nums2 = ReadArray(n);

for (int i = 0; i < n; i++)
{
    if (nums1[i] == nums2[i] && nums1.Length == nums2.Length)
    {
        if (i == n - 1)
            Console.WriteLine("The elements are equal");
    }
    else
    {
        Console.WriteLine("The elements are not equal");
        break;
    }
}
