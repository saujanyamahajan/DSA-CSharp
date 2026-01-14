public class Solution {
    public int largestElement(int[] nums) {
        
        int max = int.MinValue;
        foreach(int i in nums) 
        {
            if (i>max)
            {
                max=i;
            }
        }
        return max;
    }
}