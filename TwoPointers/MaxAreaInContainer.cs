public class Solution {
    public int MaxArea(int[] height) {
        int left=0;
        int right=height.Length-1;
        int maxArea=0;
        while(left<right)
        {
            int width=right-left;
            int h=Math.Min(height[left],height[right]);
            int area= h*width;

            maxArea=Math.Max(area,maxArea);

            if(height[left]<height[right])
                left++;
            else
                right--;
        }
        return maxArea;
    }
}