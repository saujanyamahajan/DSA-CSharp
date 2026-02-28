public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
        {
            return false;
        }
        int original =x;
        int reversed =0;
        while(x>0)
        {
            int digit = x%10;
            reversed= reversed *10 + digit;
            x=x/10;
        }
        // if (reversed == original)
        // return true;
        return original == reversed;
    }
}