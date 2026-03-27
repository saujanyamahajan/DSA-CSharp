class Solution {
    public int maxSubarraySum(int[] nums, int k) {
        int maxSum=0;
        int windowSum=0;
            // First window
        for(int i=0;i<k;i++)
        {
            windowSum=windowSum+nums[i];
        }
            maxSum=windowSum;
                // Slide the window
        for(int i=k;i<nums.Length;i++)
        {
            windowSum=windowSum+nums[i]; // add next
            windowSum=windowSum-nums[i-k]; // remove first
            maxSum=Math.Max(windowSum,maxSum);
        }
        return maxSum;
    }
}

// Idea:

// Compute sum of first window of size k
// Then slide window:
// Add next element
// Remove previous element

// Fixed window size → Sliding Window