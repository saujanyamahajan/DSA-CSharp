class Solution
{
    public bool IsSorted(List<int> nums)
    {
        //your code goes here
       for( int i =1; i<nums.Count; i++)
       {
        if (nums[i-1]>nums[i])
        {
            return false;
        }
       }
       return true;
    }
}
