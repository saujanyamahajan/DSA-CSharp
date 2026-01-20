
using System;
using System.Linq;
using System.Collections.Generic;

class HelloWorld
{
    public static void Main()
    {
        String str="hello";
        Stack<char> st=new Stack<char>();
        for( int i=0;i<str.Length;i++)
        {
            st.Push(str[i]);
        }
        String rev="";
        while(st.Count>0)
        {
            rev+=st.Pop().ToString();
        }
        Console.WriteLine(rev);
        
        
    }
}
