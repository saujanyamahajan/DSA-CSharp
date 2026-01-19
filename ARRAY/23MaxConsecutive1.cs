// Example 1:
// Input: prices = {1, 1, 0, 1, 1, 1}
// Output: 3
// Explanation: There are two consecutive 1’s and three consecutive 1’s in the array out of which maximum is 3.


// Traverse through the array:
// If nums[i] == 1, increment cnt.
// If nums[i] == 0, reset cnt to 0.
// Update maxi = max(maxi, cnt) at each step.

using System;

class Solution
{
    // Function to find maximum consecutive 1's in an array
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int cnt = 0;
        int maxi = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                cnt++;
                maxi = Math.Max(maxi, cnt);
            }
            else
            {
                cnt = 0;
            }
        }

        return maxi;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 1, 0, 1, 1, 1 };

        Solution obj = new Solution();
        int ans = obj.FindMaxConsecutiveOnes(nums);

        Console.WriteLine("The maximum consecutive 1's are " + ans);
    }
}
