// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int[] nums = { 13, 46, 24, 52, 20,9 };
        InsertionSort(nums);
        Console.WriteLine(string.Join(" ", nums));
    }
    public static void InsertionSort(int[] nums) 
    {
        int n=nums.Length;
        for(int i =1; i<n;i++)
        {
            int j=i;
            while(j>0 && nums[j-1] >nums[j])
            {
                    int temp=nums[j] ;
                    nums[j]=nums[j-1];
                    nums[j-1]=temp;
                    j--;
            }
        }
    }
}