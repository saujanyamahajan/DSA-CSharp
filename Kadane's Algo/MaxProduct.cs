//Find the maximum product of a contiguous subarray.

// Keep track of:
// best product so far
// worst product so far (because it can become best later)

public int MaxProduct(int[] nums)
{
    int maxProd = nums[0];
    int minProd = nums[0];
    int result = nums[0];

    for (int i = 1; i < nums.Length; i++)
    {
        int curr = nums[i];

        // swap if negative
        if (curr < 0)
        {
            int temp = maxProd;
            maxProd = minProd;
            minProd = temp;
        }

        maxProd = Math.Max(curr, maxProd * curr);
        minProd = Math.Min(curr, minProd * curr);

        result = Math.Max(result, maxProd);
    }

    return result;
}