
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        String str="hello world";
        String[] sarr = str.Split(" ");
        for(int i=0;i<sarr.Length;i++)
        {
            char[] carr = sarr[i].ToCharArray();
            Array.Reverse(carr);
            sarr[i]=new String(carr);
        }
        Console.WriteLine(string.Join(" ",sarr));
    }
}
