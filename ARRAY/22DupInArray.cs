
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        int[] arr = {1,5,2,5};
       List<int> alist = new List<int>();
       int flag=0;
    foreach(int a in arr)
       {
           if(alist.Contains(a))
           {
               Console.WriteLine(a);
               flag=1;
               break;
           }
           else
           alist.Add(a);
       }
       
   if(flag==0)
       Console.WriteLine("Not found");
    
      
    }
}
