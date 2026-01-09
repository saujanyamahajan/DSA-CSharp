// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
         int[] nums = { 64, 25, 12, 22, 11 };
        BubbleSort(nums);
        Console.WriteLine(string.Join(" ", nums));
    }
    public static void BubbleSort(int[] nums) 
    {
        int n=nums.Length;
        for( int i =n-1; i>=0;i--)
        {
            for(int j=0;j<=i-1;j++)
            {
                if(nums[j]>nums[j+1])
                {
                    int temp=nums[j] ;
                    nums[j]=nums[j+1];
                    nums[j+1]=temp;
                }
            }
        }
    }
}