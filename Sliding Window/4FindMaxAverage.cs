// This is a fixed sliding window problem 🔥
// 👉 Find the maximum average of any subarray of size k

// ✅ Key Idea
// Average = sum / k
// So instead of recomputing every time:
// 👉 Find max sum of subarray of size k, then divide by k

// ✅ Optimal Approach: Sliding Window (O(n))


double FindMaxAverage(int[] arr, int k)
{
 int windowSum=0;
 int maxSum=0;
 //first window
 for(int i=0;i<k;i++)
 {
    windowSum+=arr[i];
 }
 int maxSum = windowSum;

 //slide window
 for(int i=k;i<arr.Length;i++)
 {
    windowSum+=arr[i];
    windowSum+=arr[i-k];
    maxSum=Math.Max(windowSum,maxSum);
 }
 return (double)maxSum/k;

}