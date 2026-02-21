public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int,int> map=new Dictionary<int,int>();
        int res;
        for(int i=0; i<nums.Length; i++)
        {
            res=target-nums[i];
            if (map.ContainsKey(res))
                return new int[] {map[res],i};
            map[nums[i]]=i;
        }
        return new int[]{};

    }
}