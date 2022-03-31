namespace MyTechniques.Tests.Blind75.Medium
{
    public class ProductExceptSelf
    {
        public int[] GetProductExceptSelf(int[] nums)
        {
            var n = nums.Length;
            var left = new int[n];
            var right = new int[n];
            var result = new int[n];

            left[0] = 1;
            right[n - 1] = 1;

            for (var i = 1; i < n; i++)
                left[i] = nums[i - 1] * left[i - 1];

            for (var i = n - 2; i >= 0; i--)
                right[i] = nums[i + 1] * right[i + 1];

            for (var i = 0; i < n; i++)
                result[i] = left[i] * right[i];

            return result;
        }
    }
}
