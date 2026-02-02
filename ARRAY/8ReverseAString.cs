
using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        String str = "Hello";
        char[] sarr=str.ToCharArray();
        int i=0;
        int j=sarr.Length-1;
        
       while(i<j)
       {
           char temp=sarr[i];
           sarr[i]=sarr[j];
           sarr[j]=temp;           
           i++;
           j--;
       }
         String res= new String(sarr);
            Console.WriteLine(res);
    
    }
}