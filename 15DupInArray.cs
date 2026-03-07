using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,1,4,5,6,0,1,0};
        List<int> unique=new List<int>();
        List<int> dup=new List<int>();
        foreach(int i in arr)
        {
        if(unique.Contains(i) & !dup.Contains(i))
        dup.Add(i);
        else
        unique.Add(i);
        }
        foreach(int i in dup)
        {
            Console.WriteLine(i);
        }
    }
}