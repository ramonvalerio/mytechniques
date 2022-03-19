namespace MyTechniques.Tests.Blind75.Medium
{
    public class SearchInRotatedSortedArray
    {
        /// <summary>
        /// Solution: One-pass Binary Search
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        //public int Search(int[] nums, int target)
        //{
        //    var start = 0;
        //    var end = nums.Length - 1;

        //    while (start <= end)
        //    {
        //        var mid = start + (end - start) / 2;

        //        if (nums[mid] == target)
        //            return mid;

        //        if (nums[mid] >= nums[start])
        //        {
        //            if (target >= nums[start] && target < nums[mid])
        //                end = mid - 1;
        //            else
        //                start = mid + 1;
        //        }
        //        else if (target <= nums[end] && target > nums[mid])
        //            start = mid + 1;
        //        else
        //            end = mid - 1;
        //    }

        //    return -1;
        //}

        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] == target)
                    return left;

                if (nums[right] == target)
                    return right;

                left++;
                right--;
            }

            return -1;
        }
    }
}