using System;

class HelloWorld
{
    public static void Main()
    {
        String str = "madamekjiskkosknsu";
        int vowels=0,consonants=0;
        for(int i=0;i<str.Length;i++)
        {
            if(str[i].ToString().ToUpper()=="A" || str[i].ToString().ToUpper()=="E" 
            || str[i].ToString().ToUpper()=="I" || str[i].ToString().ToUpper()=="O"
            || str[i].ToString().ToUpper()=="U")
            {
                vowels++;
            }
            else
            consonants++;
        }
        Console.WriteLine("Vowels : {0} and Consonants : {1}",vowels,consonants);
    }
}
