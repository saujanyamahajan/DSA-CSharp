// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] nums = { 64, 25, 12, 22, 11 };
        SelectionSort(nums);
        Console.WriteLine(string.Join(" ", nums));   
    }
    public  static void SelectionSort (int[] nums)
    {
        int n = nums.Length;
        for( int i=0;i<n-1;i++)
        {
            int min=i;
            for(int j =i+1;j<n;j++ )
            {
                if(nums[j]<nums[min])
                min=j;
            }
            int temp=nums[min];
            nums[min]=nums[i];
            nums[i]=temp;
            
        }
    }
}

//select min and place it in the satrt