using System;

class Program
{
    static void MoveZeroes(int[] nums)
    {
        int index = 0; // points to next non-zero position

        // Step 1: Move non-zero elements forward
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index++;
            }
        }

        // Step 2: Fill remaining positions with 0
        for (int i = index; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }

    static void Main()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        MoveZeroes(nums);
        Console.WriteLine(string.Join(", ", nums));
    }
}