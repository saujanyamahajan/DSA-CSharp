// Approach :
// ASCII value of digits start from 48. So for each character , subtract 48 it will give corresponding digit.

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        String str = "123";
        int n=0;
        for(int i=0; i<str.Length; i++)
        {
            n=(n*10)+((int)str[i]+48);
        }
        Console.WriteLine(n);
    }
}