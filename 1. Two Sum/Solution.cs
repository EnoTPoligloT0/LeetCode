namespace LeetCode._1._Two_Sum;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (var i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        return [];
    }
}