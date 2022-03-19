using System;

namespace MyTechniques.Tests.Blind75.Medium
{
    public class MaximumProductSubarray
    {
        public int GetMaxProduct(int[] nums)
        {
            var n = nums.Length;
            var max = nums[0];
            var min = nums[0];
            var result = max;

            for (var i = 1; i < n; i++)
            {
                var curr = nums[i];

                var temp_max = Math.Max(curr, Math.Max(max * curr, min * curr));
                min = Math.Min(curr, Math.Min(max * curr, min * curr));
                max = temp_max;

                result = Math.Max(max, result);
            }

            return result;
        }
    }
}
