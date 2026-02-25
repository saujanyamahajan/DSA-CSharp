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

///

public class Solution {
    public bool IsPalindrome(string s) {
        int left =0;
        int right=s.Length-1;

        while(left<right)
        {
        while(left<right && !char.IsLetterOrDigit(s[left]))
        {
            left++;
        }
        while(left<right && !char.IsLetterOrDigit(s[right]))
        {
            right--;
        }
         if (char.ToLower(s[left]) != char.ToLower(s[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }
}