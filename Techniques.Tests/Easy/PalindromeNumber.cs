namespace Techniques.Tests.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var nums = x.ToString();
            var n = nums.Length;

            for (var i = 0; i < n / 2; i++)
            {
                if (nums[i] != nums[n - i - 1])
                    return false;
            }

            return true;
        }
    }
}
