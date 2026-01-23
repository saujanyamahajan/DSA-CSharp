
using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int fact=1;
        int a =5;
        for(int i=1; i<=a;i++)
        {
           fact=fact*i; 
        }
        Console.WriteLine(fact);

    }
}