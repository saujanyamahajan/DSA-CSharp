// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,1,4,5,6,0,1,0};
        int repeating=0;
        int nonrepeating=0;
        List<int> unique=new List<int>();
        List<int> dup=new List<int>();
        foreach(int i in arr)
        {
        if(unique.Contains(i) & !dup.Contains(i))
        dup.Add(i);
        else
        unique.Add(i);
        }

        if(dup.Count>0)
       repeating=dup[0];
        foreach(int i in arr)
        {
            if(!dup.Contains(i))
            {
                nonrepeating=i;
                break;
            }
        }
        Console.WriteLine("Repeating : {0} and NonRepeating : {1}",repeating,nonrepeating);

    }
}