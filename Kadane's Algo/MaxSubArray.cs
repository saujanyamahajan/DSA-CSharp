// Find the maximum sum of a contiguous subarray
//“I use Kadane’s algorithm where I decide at each step whether to extend the current subarray or start a new one.”


public int MaxSubArray(int[] nums)
{
    int currentSum = nums[0];
    int maxSum = nums[0];

    for (int i = 1; i < nums.Length; i++)
    {
        currentSum = Math.Max(nums[i], currentSum + nums[i]);
        maxSum = Math.Max(maxSum, currentSum);
    }

    return maxSum;
}

//[-2, 1, -3, 4, -1, 2, 1, -5, 4]