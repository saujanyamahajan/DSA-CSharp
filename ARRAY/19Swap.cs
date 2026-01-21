using System;

class HelloWorld
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine("a:{0},b{1}",a,b);
    }
}

