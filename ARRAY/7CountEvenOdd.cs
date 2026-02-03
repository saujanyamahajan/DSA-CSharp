using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1,2,3,6,4,8};
        int even=0;
        int odd=0;
        foreach(int i in arr)
        {
            if(i%2==0)
                even++;
            else
                odd++;
        }
         
            Console.WriteLine("Even:{0} and Odd:{1}",even,odd);
    
    }
}