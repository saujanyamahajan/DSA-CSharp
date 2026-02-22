public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0)
        return 0;
         int k = 1; // position for next unique element
         for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }
    return k;
    // List<int> alist=new List<int>();
    // foreach(int i in nums)
    // {
    // if(!alist.Contains(i))
    //     alist.Add(i);
    // }
    // return alist.Count();
    }
}