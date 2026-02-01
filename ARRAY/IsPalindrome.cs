using System;


public class HelloWorld
{
    public static void Main(string[] args)
    {
        String str = "madam";
        String rev = "";
         for(int i=str.Length-1;i>=0;i--)
        {
            rev+=str[i].ToString();
        }
        if(rev.Equals(str))
           Console.WriteLine("True");
        else
            Console.WriteLine("False");
    }
}