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
        int didSwap=0;
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
                    didSwap=1;
                }
                if(didSwap==0)
                break;
            }
        }
    }
}

//best tc -o(n)  -- sorted arreay
// worst tc - o(n*n)
// sc - o(1)