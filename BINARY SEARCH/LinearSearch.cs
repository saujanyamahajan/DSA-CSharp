
using System;

class HelloWorld
{
    public static void Main()
    {
        int[] arr = { 1, 3, 5, 7, 9 };
        int key = 5;

        int index = LinearSearch(arr, key);

        if (index != -1)
            Console.WriteLine($"Element found at index {index}");
        else
            Console.WriteLine("Element not found");
    }

    static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
                return i;
        }
        return -1;
    }
}