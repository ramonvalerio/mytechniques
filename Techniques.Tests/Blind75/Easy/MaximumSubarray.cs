using System;

namespace MyTechniques.Tests.Blind75.Easy
{
    public class MaximumSubarray
    {
        // Approach: Dynamic Programming
        public int MaxSubArray(int[] nums)
        {
            var n = nums.Length;
            var currSubArr = nums[0];
            var maxSubArr = nums[0];

            for (var i = 1; i < n; i++)
            {
                currSubArr = Math.Max(nums[i], currSubArr + nums[i]);
                maxSubArr = Math.Max(maxSubArr, currSubArr);
            }

            return maxSubArr;
        }
    }
}