// Given a sorted array, find:
// 👉 the smallest element > target (or ≥ target)


int FindCeiling(int[] arr, int target)
{
    int left = 0, right = arr.Length - 1;
    int result = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (arr[mid] > target)
        {
            result = arr[mid]; // potential answer
            right = mid - 1;   // try smaller on left
        }
        else
        {
            left = mid + 1;
        }
    }

    return result;
}