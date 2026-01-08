public class Solution {
    public int SecondLargestElement(List<int> nums) {
        //your code goes here
      int max= int.MinValue;
      int secondMax= int.MinValue;

      foreach(int i in nums)
      {
        if(i > max)
        {
            secondMax=max;
            max=i;
        }
        if(i!=max && secondMax<i)
        {
            secondMax=i;
        }
      }
      return secondMax==int.MinValue?-1:secondMax;
    }
}