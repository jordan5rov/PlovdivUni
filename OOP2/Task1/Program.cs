// See https://aka.ms/new-console-template for more information
/*
 * Write a program that reads two arrays from the console and compares them element by element and by their lenght.
 */

int[] ReadArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

Console.Write("Enter the lenght of the arrays: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the numbers for the first array");
int[] nums1 = ReadArray(n);
Console.Write("Enter the numbers for the second array");
int[] nums2 = ReadArray(n);

for (int i = 0; i < n; i++)
{
    if (nums1[i] == nums2[i] && nums1.Length == nums2.Length)
    {
        Console.WriteLine("The elements are equal");
    }
    else
    {
        Console.WriteLine("The elements are not equal");
    }
}
