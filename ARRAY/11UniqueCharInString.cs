using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        String str = "hello";
        List<char> unique=new List<char>();
        for( int i=0; i<str.Length; i++)
        {
            if(!unique.Contains(str[i]))
            unique.Add(str[i]);
        }
        String res="";
        foreach(char c in unique)
        {
            res=res+c.ToString();
        }
        Console.WriteLine (res);
    }
}