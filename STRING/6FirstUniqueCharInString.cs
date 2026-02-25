public class Solution {
    public int FirstUniqChar(string s) {
       Dictionary<char,int> dict=new Dictionary<char,int>();
       foreach( char i in s)
       {
        if(dict.ContainsKey(i))
        dict[i]++;
        else
        dict[i]=1;
       }

       for(int i=0;i<s.Length;i++)
       {
        if(dict[s[i]]==1)
        return i;
       }
       return -1;
    }
}