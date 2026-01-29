using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        String str = "hello";
        Dictionary<char,int> dict=new Dictionary<char,int>();
        for( int i=0; i<str.Length; i++)
        {
            if(dict.ContainsKey(str[i]))
            dict[str[i]]+=1;
            else
            dict.Add(str[i],1);
        }

        foreach(var kvp in dict)
        {
            if(kvp.Value==1)
            {
                Console.WriteLine(kvp.Key);
                break;
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
        }
    }
}