using System.Globalization;

namespace Techniques.Tests.Easy
{
    public class Palindrome
    {
        public bool IsPalindromeNumber(int x)
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

        public bool IsPalindromeString(string s)
        {
            var arr = s.ToLower().Replace('-', ' ').Split(' ');
            s = string.Join("", arr);
            var n = s.Length;

            for (var i = 0; i < n / 2; i++)
            {
                var leftLetter = CharUnicodeInfo.GetUnicodeCategory(s[i]);
                var rightLetter = CharUnicodeInfo.GetUnicodeCategory(s[n-i-1]);

                if (leftLetter != rightLetter)
                    return false;
            }

            return true;
        }
    }
}
