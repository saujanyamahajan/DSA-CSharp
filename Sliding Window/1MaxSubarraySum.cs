class Solution {
    public int maxSubarraySum(int[] nums, int k) {
        // Code here
        int maxSum=0;
        int windowSum=0;
        for(int i=0;i<k;i++)
            windowSum=windowSum+nums[i];
            maxSum=windowSum;
        for(int i=k;i<nums.Length;i++)
        {
            windowSum=windowSum+nums[i];
            windowSum=windowSum-nums[i-k];
            maxSum=Math.Max(windowSum,maxSum);
        }
        return maxSum;
    }
}