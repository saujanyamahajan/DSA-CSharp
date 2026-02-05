
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,3,0,-1,6,4,8};
        int i=0;
        int j=arr.Length-1;
        while(i<j)
        {
            int temp=arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
            i++;
            j--;
        }
          foreach(int a in arr)
        {
            Console.WriteLine(a);
        }
    }
}