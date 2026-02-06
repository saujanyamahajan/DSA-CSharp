// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,3,0,-1,6,4,8};
        List<int> unique = new List<int>();
        foreach(int i in arr)
        {
            if(!unique.Contains(i))
            {
                unique.Add(i);
            }
        }
        arr=unique.ToArray();
        for(int j=0;j<arr.Length;j++)
        {
                 Console.WriteLine(arr[j]);
        }
    }
}