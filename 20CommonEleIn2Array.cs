
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
       int[] arr1 = {1,2,4,5,0};
        int[] arr2 = {2,5,9,10,11,22,14,15};
        
       HashSet<int> set = new HashSet<int>(arr1);
        List<int> result = new List<int>();

        foreach (int j in arr2)
        {
            if (set.Contains(j))
                result.Add(j);
        }

        foreach (int k in result)
        {
            Console.WriteLine(k);
        }
    }
}
