
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
       int[] arr1 = {1,2,4,5};
        int sum=0;
        int n=arr1.Length-1;
        int expectedSum=(n*(n+1))/2
        foreach(int a in arr)
            sum+=a;
       Console.WriteLine("Missing : {0}",expectedSum-sum);
      
    }
}
