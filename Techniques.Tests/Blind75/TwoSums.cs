using System.Collections.Generic;

namespace Techniques.Tests.Blind75
{
    public class TwoSum
    {
        public int[] GetIndexesOfTwoSum(int[] nums, int target)
        {
            var n = nums.Length;
            var map = new Dictionary<int, int>();

            for (var i = 0; i < n; i++)
            {
                var rest = target - nums[i];

                if (map.ContainsKey(rest))
                    return new int[] { i, map[rest] };

                if(!map.ContainsKey(nums[i]))
                    map.Add(nums[i], i);
            }

            return new int[] { 0, 1 };
        }
    }
}