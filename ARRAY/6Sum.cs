
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,3};
        int sum=0;
        foreach(int i in arr)
        {
            sum=sum+i;
        }
         
            Console.WriteLine(sum);
    
    }
}