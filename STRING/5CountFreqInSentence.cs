
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        String str="hello world hello duniya ok ok";
        String[] sarr = str.Split(" ");
    Dictionary<String,int> dict = new Dictionary<String,int>();
        for(int i=0;i<sarr.Length;i++)
        {
            if(dict.ContainsKey(sarr[i]))
            dict[sarr[i]]+=1;
            else
            dict.Add(sarr[i],1);
        }
        foreach(var kvp in dict.OrderBy(kvp=>kvp.Value))
        {
          Console.WriteLine("Word : {0} - Count : {1}",kvp.Key,kvp.Value);

        }
    }
}
